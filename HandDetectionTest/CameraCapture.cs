using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Accord.Statistics.Distributions.Fitting;
using Accord.Statistics.Distributions.Multivariate;

using Accord.Statistics.Models.Fields;
using Accord.Statistics.Models.Fields.Functions;
using Accord.Statistics.Models.Fields.Learning;

using Accord.Statistics.Models.Markov;
using Accord.Statistics.Models.Markov.Learning;
using Accord.Statistics.Models.Markov.Topology;
using HandDetectionTest.Native;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


namespace HandDetectionTest
{
    public partial class CameraCapture : Form
    {
        private Capture _capture;
        private bool _captureInProgress;
        private HaarCascade _haarFist, _haarHand, _haarFace, _haarPalm;
        private Image<Bgr, Byte> _imageFrame;
        private ArrayList aL;
        private double defaultValue = 1.10;  //Value for Scale Factor
        private ToolTip toolTip;
        private Database database;
        private HiddenMarkovClassifier<MultivariateNormalDistribution> hmm;
        private HiddenConditionalRandomField<double[]> hcrf;
        int Xcoord, Ycoord;
        List<Point> points = new List<Point>();


        public CameraCapture()
        {
            InitializeComponent();
            aL = new ArrayList();
            toolTip = new ToolTip();
            database = new Database();
            gridSamples.AutoGenerateColumns = false;
            cbClasses.DataSource = database.Classes;
            gridSamples.DataSource = database.Samples;
            openDataDialog.InitialDirectory = Path.Combine(Application.StartupPath, "Resource");
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            _imageFrame = _capture.QueryFrame();

            if (_imageFrame != null)
            {
                Image<Gray, Byte> grayFrame = _imageFrame.Convert<Gray, Byte>();
                grayFrame._EqualizeHist();

                double scaleFactor = defaultValue + FactorTrackBar.Value * 0.01;

                var hands = grayFrame.DetectHaarCascade((HaarCascade)comboBox.SelectedValue, scaleFactor, 
                    NeighborsTrackBar.Value, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, Size.Empty)[0];

                //Hand Plam Detection
               var handPlam = grayFrame.DetectHaarCascade(_haarPalm, scaleFactor,
                    NeighborsTrackBar.Value, HAAR_DETECTION_TYPE.FIND_BIGGEST_OBJECT, Size.Empty)[0];


               foreach (var hand in hands)
               {
                   //Draw the Rectangle
                   _imageFrame.Draw(hand.rect, new Bgr(Color.Green), 3);

                   //Center point(x,y) of Rectangle
                   int x = (hand.rect.Left + hand.rect.Right) / 2;
                   int y = (hand.rect.Top + hand.rect.Bottom) / 2;

                   Xcoord = x;
                   Ycoord = y;

                   //Set the value fo x and y
                   display_point.Text = "Center point: X = " + x + " Y = " + y;
                 

                   //Draw Circle in the mid point of Rectangle
                   _imageFrame.Draw(new CircleF(new Point(x, y), 2), new Bgr(Color.Red), 2);

                   //Move Cursor 
                   //Cursor.Position = new Point(x,y);

               }

                ////Hand Plam Detection
                //foreach(var handP in handPlam)
                //{
                //    _imageFrame.Draw(handP.rect, new Bgr(Color.Green), 3);

                //    int x = (handP.rect.Left + handP.rect.Right) / 2;
                //    int y = (handP.rect.Top + handP.rect.Bottom) / 2;

                //    display_point.Text = "Center point: X = " + x + " Y = " + y;

                //    _imageFrame.Draw(new CircleF(new Point(x, y), 2), new Bgr(Color.Red), 2);
                //}
            }

            CamImageBox.Image = _imageFrame;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_capture != null)
            {
                if (_captureInProgress)
                {
                    //stop the capture
                    btnStart.Text = "Resume";
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //start the capture
                    btnStart.Text = "Pause";
                    Application.Idle += ProcessFrame;
                }

                _captureInProgress = !_captureInProgress;
            }
        }

        private void ReleaseData()
        {
            if (_capture != null)
            {
                _capture.Dispose();
            }
        }

        private void CameraCapture_Load(object sender, EventArgs e)
        {
            try
            {
                _capture = new Capture();
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            //Initialize the HaarCascade
            _haarFace = new HaarCascade("haarcascade_frontalface_default.xml");
            _haarHand = new HaarCascade("haarcascade_hand.xml");
            _haarFist = new HaarCascade("hand_two.xml"); //close hand   
            _haarPalm = new HaarCascade("palm.xml");
            //_haarFist = new HaarCascade("hand.xml"); //close hand

            //Set the TrackBar value
            double val = defaultValue + FactorTrackBar.Value * 0.01;
            displayScaleFactor.Text = val.ToString("F2"); //F2 2-digits after decimal point
            displayMinNeighbors.Text = NeighborsTrackBar.Value.ToString();

            comboBox.DisplayMember = "Text";
            comboBox.ValueMember = "Value";
            //Initialize ComboBox items
            var items = new[] { 
                new { Text = "Fist", Value = _haarFist }, 
                new { Text = "Hand", Value = _haarHand },  
                new {Text = "Palm", Value = _haarPalm },
                new {Text = "Face", Value = _haarFace }
            };
            //Set ComboBox items
            comboBox.DataSource = items;

            //Show ToolTip
            toolTip.SetToolTip(this.FactorTrackBar, "Increasing search window size by increasing Scale Factor.");
            toolTip.SetToolTip(this.NeighborsTrackBar, "Increasing Min Neighbors get less Detection but high quality.");
        }

        private void FactorTrackBar_ValueChanged(object sender, EventArgs e)
        {
            double val = defaultValue + FactorTrackBar.Value * 0.01;
            displayScaleFactor.Text = val.ToString("F2");//F2 2-digits after decimal point
        }

        private void NeighborsTrackBar_ValueChanged(object sender, EventArgs e)
        {
            displayMinNeighbors.Text = NeighborsTrackBar.Value.ToString();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox.SelectedValue.ToString());
        }

 
        private void btnLearnHMM_Click(object sender, EventArgs e)
        {
            if (gridSamples.Rows.Count == 0)
            {
                MessageBox.Show("Please load or insert some data first.");
                return;
            }

            BindingList<Sequence> samples = database.Samples;
            BindingList<String> classes = database.Classes;

            double[][][] inputs = new double[samples.Count][][];
            int[] outputs = new int[samples.Count];

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = samples[i].Input;
                outputs[i] = samples[i].Output;
            }

            int states = 5;
            int iterations = 0;
            double tolerance = 0.01;
            bool rejection = false;


            hmm = new HiddenMarkovClassifier<MultivariateNormalDistribution>(classes.Count,
                new Forward(states), new MultivariateNormalDistribution(2), classes.ToArray());


            // Create the learning algorithm for the ensemble classifier
            var teacher = new HiddenMarkovClassifierLearning<MultivariateNormalDistribution>(hmm,

                // Train each model using the selected convergence criteria
                i => new BaumWelchLearning<MultivariateNormalDistribution>(hmm.Models[i])
                {
                    Tolerance = tolerance,
                    Iterations = iterations,

                    FittingOptions = new NormalOptions()
                    {
                        Regularization = 1e-5
                    }
                }
            );

            teacher.Empirical = true;
            teacher.Rejection = rejection;


            // Run the learning algorithm
            double error = teacher.Run(inputs, outputs);


            // Classify all training instances
            foreach (var sample in database.Samples)
            {
                sample.RecognizedAs = hmm.Compute(sample.Input);
            }

            foreach (DataGridViewRow row in gridSamples.Rows)
            {
                var sample = row.DataBoundItem as Sequence;
                row.DefaultCellStyle.BackColor = (sample.RecognizedAs == sample.Output) ?
                    Color.LightGreen : Color.White;
            }

            btnLearnHCRF.Enabled = true;
        }

        private void btnLearnHCRF_Click(object sender, EventArgs e)
        {
            if (gridSamples.Rows.Count == 0)
            {
                MessageBox.Show("Please load or insert some data first.");
                return;
            }

            var samples = database.Samples;
            var classes = database.Classes;

            double[][][] inputs = new double[samples.Count][][];
            int[] outputs = new int[samples.Count];

            for (int i = 0; i < inputs.Length; i++)
            {
                inputs[i] = samples[i].Input;
                outputs[i] = samples[i].Output;
            }

            int iterations = 100;
            double tolerance = 0.01;


            hcrf = new HiddenConditionalRandomField<double[]>(
                new MarkovMultivariateFunction(hmm));


            // Create the learning algorithm for the ensemble classifier
            var teacher = new HiddenResilientGradientLearning<double[]>(hcrf)
            {
                Iterations = iterations,
                Tolerance = tolerance
            };


            // Run the learning algorithm
            double error = teacher.Run(inputs, outputs);


            foreach (var sample in database.Samples)
            {
                sample.RecognizedAs = hcrf.Compute(sample.Input);
            }

            foreach (DataGridViewRow row in gridSamples.Rows)
            {
                var sample = row.DataBoundItem as Sequence;
                row.DefaultCellStyle.BackColor = (sample.RecognizedAs == sample.Output) ?
                    Color.LightGreen : Color.White;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
             //canvas.Clear();
            panelUserLabeling.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            addGesture();
        }
        private void addGesture()
        {
            string selectedItem = cbClasses.SelectedItem as String;
            string classLabel = String.IsNullOrEmpty(selectedItem) ?
                cbClasses.Text : selectedItem;

            if (database.Add(points.ToArray(), classLabel) != null)
            {
                //canvas.Clear();

                if (database.Classes.Count >= 2 &&
                    database.SamplesPerClass() >= 3)
                    btnLearnHMM.Enabled = true;

                panelUserLabeling.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addGesture();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelClassification.Visible = false;
            panelUserLabeling.Visible = true;
        }

        private void openDataDialog_FileOk(object sender, CancelEventArgs e)
        {
            hmm = null;
            hcrf = null;

            using (var stream = openDataDialog.OpenFile())
                database.Load(stream);

            btnLearnHMM.Enabled = true;
            btnLearnHCRF.Enabled = false;

            panelClassification.Visible = false;
            panelUserLabeling.Visible = false;
        }

        private void menuFile_Opening(object sender, CancelEventArgs e)
        {

        }

        private void saveDataDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (var stream = saveDataDialog.OpenFile())
                database.Save(stream);
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }
        private void openDataStripMenuItem_Click(object sender, EventArgs e)
        {
            openDataDialog.ShowDialog();
        }

        private void saveDataStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDataDialog.ShowDialog();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            menuFile.Show(button4, button4.PointToClient(Cursor.Position));
        }

        private void saveGestureBtn_Click(object sender, EventArgs e)
        {
            addGesture();
        }

        private void addGestureBtn_Click(object sender, EventArgs e)
        {
            points.Clear();
            coorText.Text = "";
            Application.Idle += addCoord; 
        }

        private void addCoord(object sender, EventArgs e)
        {
            coorText.AppendText(Xcoord + " " + Ycoord+"\n");  

            points.Add(new Point(Xcoord,Ycoord));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point[] P = new Point[30000];
            for (int i = 0; i < points.Count; i++)
            {
                P[i] = points[i];
                richTextBox1.AppendText(P[i].ToString());
            }
            double[][] input = Sequence.Preprocess(P);

            //if (input.Length < 5)
            //{
            //    panelUserLabeling.Visible = false;
            //    panelClassification.Visible = false;
            //    return;
            //}

            if (hmm == null && hcrf == null)
            {
                panelUserLabeling.Visible = true;
                panelClassification.Visible = false;
            }

            else
            {
                int index = (hcrf != null) ?
                    hcrf.Compute(input) : hmm.Compute(input);

                string label = database.Classes[index];
                lbHaveYouDrawn.Text = String.Format("Have you drawn a {0}?", label);
                panelClassification.Visible = true;
                panelUserLabeling.Visible = false;
            }
            Application.Idle -= addCoord; 
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {

        }
    
   }

}
