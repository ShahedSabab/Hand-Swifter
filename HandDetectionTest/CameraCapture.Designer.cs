namespace HandDetectionTest
{
    partial class CameraCapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraCapture));
            this.btnStart = new System.Windows.Forms.Button();
            this.CamImageBox = new Emgu.CV.UI.ImageBox();
            this.DefaultTab = new System.Windows.Forms.TabPage();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.coorText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayMinNeighbors = new System.Windows.Forms.Label();
            this.displayScaleFactor = new System.Windows.Forms.Label();
            this.display_point = new System.Windows.Forms.Label();
            this.lb_MinNeighbors = new System.Windows.Forms.Label();
            this.lb_ScaleFactor = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.NeighborsTrackBar = new System.Windows.Forms.TrackBar();
            this.FactorTrackBar = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panelUserLabeling = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.lbWhat = new System.Windows.Forms.Label();
            this.btnLearnHCRF = new System.Windows.Forms.Button();
            this.btnLearnHMM = new System.Windows.Forms.Button();
            this.gridSamples = new System.Windows.Forms.DataGridView();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colClassification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDataDialog = new System.Windows.Forms.OpenFileDialog();
            this.lbHaveYouDrawn = new System.Windows.Forms.Label();
            this.panelClassification = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addGestureBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).BeginInit();
            this.SettingsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorTrackBar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.panelUserLabeling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSamples)).BeginInit();
            this.menuFile.SuspendLayout();
            this.panelClassification.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 418);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CamImageBox
            // 
            this.CamImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CamImageBox.Location = new System.Drawing.Point(12, 12);
            this.CamImageBox.Name = "CamImageBox";
            this.CamImageBox.Size = new System.Drawing.Size(565, 400);
            this.CamImageBox.TabIndex = 2;
            this.CamImageBox.TabStop = false;
            // 
            // DefaultTab
            // 
            this.DefaultTab.Location = new System.Drawing.Point(4, 26);
            this.DefaultTab.Name = "DefaultTab";
            this.DefaultTab.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultTab.Size = new System.Drawing.Size(190, 370);
            this.DefaultTab.TabIndex = 1;
            this.DefaultTab.Text = "Default";
            this.DefaultTab.UseVisualStyleBackColor = true;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.coorText);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.displayMinNeighbors);
            this.SettingsTab.Controls.Add(this.displayScaleFactor);
            this.SettingsTab.Controls.Add(this.display_point);
            this.SettingsTab.Controls.Add(this.lb_MinNeighbors);
            this.SettingsTab.Controls.Add(this.lb_ScaleFactor);
            this.SettingsTab.Controls.Add(this.comboBox);
            this.SettingsTab.Controls.Add(this.NeighborsTrackBar);
            this.SettingsTab.Controls.Add(this.FactorTrackBar);
            this.SettingsTab.Location = new System.Drawing.Point(4, 26);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(190, 370);
            this.SettingsTab.TabIndex = 0;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // coorText
            // 
            this.coorText.Location = new System.Drawing.Point(11, 263);
            this.coorText.Multiline = true;
            this.coorText.Name = "coorText";
            this.coorText.Size = new System.Drawing.Size(131, 101);
            this.coorText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select HaarCascade";
            // 
            // displayMinNeighbors
            // 
            this.displayMinNeighbors.AutoSize = true;
            this.displayMinNeighbors.Location = new System.Drawing.Point(87, 80);
            this.displayMinNeighbors.Name = "displayMinNeighbors";
            this.displayMinNeighbors.Size = new System.Drawing.Size(0, 13);
            this.displayMinNeighbors.TabIndex = 6;
            // 
            // displayScaleFactor
            // 
            this.displayScaleFactor.AutoSize = true;
            this.displayScaleFactor.Location = new System.Drawing.Point(80, 16);
            this.displayScaleFactor.Name = "displayScaleFactor";
            this.displayScaleFactor.Size = new System.Drawing.Size(0, 13);
            this.displayScaleFactor.TabIndex = 5;
            // 
            // display_point
            // 
            this.display_point.AutoSize = true;
            this.display_point.Location = new System.Drawing.Point(6, 193);
            this.display_point.Name = "display_point";
            this.display_point.Size = new System.Drawing.Size(67, 13);
            this.display_point.TabIndex = 4;
            this.display_point.Text = "Center point:";
            // 
            // lb_MinNeighbors
            // 
            this.lb_MinNeighbors.AutoSize = true;
            this.lb_MinNeighbors.Location = new System.Drawing.Point(6, 80);
            this.lb_MinNeighbors.Name = "lb_MinNeighbors";
            this.lb_MinNeighbors.Size = new System.Drawing.Size(75, 13);
            this.lb_MinNeighbors.TabIndex = 4;
            this.lb_MinNeighbors.Text = "Min Neighbors";
            // 
            // lb_ScaleFactor
            // 
            this.lb_ScaleFactor.AutoSize = true;
            this.lb_ScaleFactor.Location = new System.Drawing.Point(6, 16);
            this.lb_ScaleFactor.Name = "lb_ScaleFactor";
            this.lb_ScaleFactor.Size = new System.Drawing.Size(67, 13);
            this.lb_ScaleFactor.TabIndex = 3;
            this.lb_ScaleFactor.Text = "Scale Factor";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(9, 160);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 2;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // NeighborsTrackBar
            // 
            this.NeighborsTrackBar.LargeChange = 1;
            this.NeighborsTrackBar.Location = new System.Drawing.Point(9, 96);
            this.NeighborsTrackBar.Maximum = 15;
            this.NeighborsTrackBar.Name = "NeighborsTrackBar";
            this.NeighborsTrackBar.Size = new System.Drawing.Size(170, 45);
            this.NeighborsTrackBar.TabIndex = 1;
            this.NeighborsTrackBar.Value = 4;
            this.NeighborsTrackBar.ValueChanged += new System.EventHandler(this.NeighborsTrackBar_ValueChanged);
            // 
            // FactorTrackBar
            // 
            this.FactorTrackBar.LargeChange = 1;
            this.FactorTrackBar.Location = new System.Drawing.Point(9, 32);
            this.FactorTrackBar.Maximum = 6;
            this.FactorTrackBar.Name = "FactorTrackBar";
            this.FactorTrackBar.Size = new System.Drawing.Size(170, 45);
            this.FactorTrackBar.TabIndex = 0;
            this.FactorTrackBar.Value = 4;
            this.FactorTrackBar.ValueChanged += new System.EventHandler(this.FactorTrackBar_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Controls.Add(this.DefaultTab);
            this.tabControl1.Location = new System.Drawing.Point(583, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(12, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(198, 400);
            this.tabControl1.TabIndex = 3;
            // 
            // panelUserLabeling
            // 
            this.panelUserLabeling.BackColor = System.Drawing.Color.White;
            this.panelUserLabeling.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUserLabeling.Controls.Add(this.btnClear);
            this.panelUserLabeling.Controls.Add(this.btnInsert);
            this.panelUserLabeling.Controls.Add(this.label7);
            this.panelUserLabeling.Controls.Add(this.cbClasses);
            this.panelUserLabeling.Controls.Add(this.lbWhat);
            this.panelUserLabeling.Location = new System.Drawing.Point(316, 429);
            this.panelUserLabeling.Name = "panelUserLabeling";
            this.panelUserLabeling.Size = new System.Drawing.Size(461, 74);
            this.panelUserLabeling.TabIndex = 42;
            this.panelUserLabeling.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(222, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(225, 21);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Forget my drawing, clear the screen.";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(222, 30);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(225, 35);
            this.btnInsert.TabIndex = 27;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "I\'ve drawn a";
            this.label7.UseCompatibleTextRendering = true;
            // 
            // cbClasses
            // 
            this.cbClasses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClasses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClasses.Location = new System.Drawing.Point(81, 35);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(101, 21);
            this.cbClasses.TabIndex = 23;
            // 
            // lbWhat
            // 
            this.lbWhat.AutoSize = true;
            this.lbWhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhat.Location = new System.Drawing.Point(8, 11);
            this.lbWhat.Name = "lbWhat";
            this.lbWhat.Size = new System.Drawing.Size(183, 27);
            this.lbWhat.TabIndex = 25;
            this.lbWhat.Text = "What have you drawn?";
            this.lbWhat.UseCompatibleTextRendering = true;
            // 
            // btnLearnHCRF
            // 
            this.btnLearnHCRF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLearnHCRF.Enabled = false;
            this.btnLearnHCRF.Location = new System.Drawing.Point(158, 525);
            this.btnLearnHCRF.Name = "btnLearnHCRF";
            this.btnLearnHCRF.Size = new System.Drawing.Size(152, 40);
            this.btnLearnHCRF.TabIndex = 44;
            this.btnLearnHCRF.Text = "Create a Hidden Conditional Random Field";
            this.btnLearnHCRF.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLearnHCRF.UseCompatibleTextRendering = true;
            this.btnLearnHCRF.UseVisualStyleBackColor = true;
            this.btnLearnHCRF.Click += new System.EventHandler(this.btnLearnHCRF_Click);
            // 
            // btnLearnHMM
            // 
            this.btnLearnHMM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLearnHMM.Enabled = false;
            this.btnLearnHMM.Location = new System.Drawing.Point(0, 525);
            this.btnLearnHMM.Name = "btnLearnHMM";
            this.btnLearnHMM.Size = new System.Drawing.Size(144, 40);
            this.btnLearnHMM.TabIndex = 43;
            this.btnLearnHMM.Text = "Create a Hidden Markov Model Classifier";
            this.btnLearnHMM.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLearnHMM.UseCompatibleTextRendering = true;
            this.btnLearnHMM.UseVisualStyleBackColor = true;
            this.btnLearnHMM.Click += new System.EventHandler(this.btnLearnHMM_Click);
            // 
            // gridSamples
            // 
            this.gridSamples.AllowUserToAddRows = false;
            this.gridSamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSamples.BackgroundColor = System.Drawing.Color.White;
            this.gridSamples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSamples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colImage,
            this.colClassification});
            this.gridSamples.GridColor = System.Drawing.SystemColors.ControlLight;
            this.gridSamples.Location = new System.Drawing.Point(830, 12);
            this.gridSamples.Name = "gridSamples";
            this.gridSamples.Size = new System.Drawing.Size(174, 449);
            this.gridSamples.TabIndex = 46;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "Bitmap";
            this.colImage.FillWeight = 30F;
            this.colImage.HeaderText = "Gesture";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colClassification
            // 
            this.colClassification.DataPropertyName = "OutputName";
            this.colClassification.FillWeight = 40F;
            this.colClassification.HeaderText = "Class";
            this.colClassification.Name = "colClassification";
            this.colClassification.ReadOnly = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(849, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 40);
            this.button4.TabIndex = 45;
            this.button4.Text = "Database";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuFile.Name = "contextMenuStrip1";
            this.menuFile.Size = new System.Drawing.Size(104, 48);
            this.menuFile.Opening += new System.ComponentModel.CancelEventHandler(this.menuFile_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "Open";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.openDataStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem2.Text = "Save";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.saveDataStripMenuItem_Click);
            // 
            // saveDataDialog
            // 
            this.saveDataDialog.DefaultExt = "xml";
            this.saveDataDialog.Filter = "XML files|*.xml|All files|*.*";
            this.saveDataDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveDataDialog_FileOk);
            // 
            // openDataDialog
            // 
            this.openDataDialog.DefaultExt = "xml";
            this.openDataDialog.FileName = "openFileDialog1";
            this.openDataDialog.Filter = "XML files|*.xml|All files|*.*";
            this.openDataDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openDataDialog_FileOk);
            // 
            // lbHaveYouDrawn
            // 
            this.lbHaveYouDrawn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHaveYouDrawn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHaveYouDrawn.Location = new System.Drawing.Point(3, 15);
            this.lbHaveYouDrawn.Name = "lbHaveYouDrawn";
            this.lbHaveYouDrawn.Size = new System.Drawing.Size(437, 25);
            this.lbHaveYouDrawn.TabIndex = 25;
            this.lbHaveYouDrawn.Text = "Have you drawn a {Foo} ?";
            this.lbHaveYouDrawn.UseCompatibleTextRendering = true;
            // 
            // panelClassification
            // 
            this.panelClassification.BackColor = System.Drawing.Color.White;
            this.panelClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClassification.Controls.Add(this.button3);
            this.panelClassification.Controls.Add(this.button2);
            this.panelClassification.Controls.Add(this.lbHaveYouDrawn);
            this.panelClassification.Location = new System.Drawing.Point(316, 509);
            this.panelClassification.Name = "panelClassification";
            this.panelClassification.Size = new System.Drawing.Size(461, 74);
            this.panelClassification.TabIndex = 48;
            this.panelClassification.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(107, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "No...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Yes!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addGestureBtn
            // 
            this.addGestureBtn.Location = new System.Drawing.Point(86, 418);
            this.addGestureBtn.Name = "addGestureBtn";
            this.addGestureBtn.Size = new System.Drawing.Size(75, 37);
            this.addGestureBtn.TabIndex = 49;
            this.addGestureBtn.Text = "Add Gesture";
            this.addGestureBtn.UseVisualStyleBackColor = true;
            this.addGestureBtn.Click += new System.EventHandler(this.addGestureBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 37);
            this.button1.TabIndex = 51;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1030, 279);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 52;
            this.richTextBox1.Text = "";
            // 
            // CameraCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 588);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addGestureBtn);
            this.Controls.Add(this.panelClassification);
            this.Controls.Add(this.gridSamples);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLearnHCRF);
            this.Controls.Add(this.btnLearnHMM);
            this.Controls.Add(this.panelUserLabeling);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CamImageBox);
            this.Controls.Add(this.btnStart);
            this.Name = "CameraCapture";
            this.Text = "Camera Output";
            this.Load += new System.EventHandler(this.CameraCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CamImageBox)).EndInit();
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NeighborsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactorTrackBar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.panelUserLabeling.ResumeLayout(false);
            this.panelUserLabeling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSamples)).EndInit();
            this.menuFile.ResumeLayout(false);
            this.panelClassification.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private Emgu.CV.UI.ImageBox CamImageBox;
        private System.Windows.Forms.TabPage DefaultTab;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.Label lb_MinNeighbors;
        private System.Windows.Forms.Label lb_ScaleFactor;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TrackBar NeighborsTrackBar;
        private System.Windows.Forms.TrackBar FactorTrackBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label display_point;
        private System.Windows.Forms.Label displayMinNeighbors;
        private System.Windows.Forms.Label displayScaleFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUserLabeling;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label lbWhat;
        private System.Windows.Forms.Button btnLearnHCRF;
        private System.Windows.Forms.Button btnLearnHMM;
        private System.Windows.Forms.DataGridView gridSamples;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClassification;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.SaveFileDialog saveDataDialog;
        private System.Windows.Forms.OpenFileDialog openDataDialog;
        private System.Windows.Forms.Label lbHaveYouDrawn;
        private System.Windows.Forms.Panel panelClassification;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addGestureBtn;
        private System.Windows.Forms.TextBox coorText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

