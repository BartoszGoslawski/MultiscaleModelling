namespace App3
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRandomGrow = new System.Windows.Forms.Button();
            this.txtNumberOfGrains = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumberOfColors = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnVonNeumann = new System.Windows.Forms.Button();
            this.btnMoore = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImportBitmap = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExportBitmap = new System.Windows.Forms.ToolStripMenuItem();
            this.txtInclusionNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboInclusionType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInclusionsSize = new System.Windows.Forms.TextBox();
            this.btnGrainBoundaryShapeControl = new System.Windows.Forms.Button();
            this.btnCheckSizes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPhases = new System.Windows.Forms.Label();
            this.lblGB = new System.Windows.Forms.Label();
            this.lblInclusions = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLeaveboundaries = new System.Windows.Forms.Button();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCordinates = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMCphases = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMonteCarloBegin = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMCiteration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMonteCarloP = new System.Windows.Forms.ComboBox();
            this.btnMonteCarlo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 492);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRandomGrow
            // 
            this.btnRandomGrow.Location = new System.Drawing.Point(559, 33);
            this.btnRandomGrow.Margin = new System.Windows.Forms.Padding(4);
            this.btnRandomGrow.Name = "btnRandomGrow";
            this.btnRandomGrow.Size = new System.Drawing.Size(133, 84);
            this.btnRandomGrow.TabIndex = 1;
            this.btnRandomGrow.Text = "Random Grain  Growth";
            this.btnRandomGrow.UseVisualStyleBackColor = true;
            this.btnRandomGrow.Click += new System.EventHandler(this.btnRandomGrow_Click);
            // 
            // txtNumberOfGrains
            // 
            this.txtNumberOfGrains.Location = new System.Drawing.Point(704, 55);
            this.txtNumberOfGrains.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfGrains.Name = "txtNumberOfGrains";
            this.txtNumberOfGrains.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfGrains.TabIndex = 2;
            this.txtNumberOfGrains.Text = "800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of grains";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(856, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of colors";
            // 
            // txtNumberOfColors
            // 
            this.txtNumberOfColors.Location = new System.Drawing.Point(861, 54);
            this.txtNumberOfColors.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberOfColors.Name = "txtNumberOfColors";
            this.txtNumberOfColors.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOfColors.TabIndex = 3;
            this.txtNumberOfColors.Text = "5";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(416, 530);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnVonNeumann
            // 
            this.btnVonNeumann.Location = new System.Drawing.Point(559, 126);
            this.btnVonNeumann.Margin = new System.Windows.Forms.Padding(4);
            this.btnVonNeumann.Name = "btnVonNeumann";
            this.btnVonNeumann.Size = new System.Drawing.Size(133, 28);
            this.btnVonNeumann.TabIndex = 4;
            this.btnVonNeumann.Text = "VonNeumann";
            this.btnVonNeumann.UseVisualStyleBackColor = true;
            this.btnVonNeumann.Click += new System.EventHandler(this.btnVonNeumann_Click);
            // 
            // btnMoore
            // 
            this.btnMoore.Location = new System.Drawing.Point(559, 161);
            this.btnMoore.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoore.Name = "btnMoore";
            this.btnMoore.Size = new System.Drawing.Size(133, 28);
            this.btnMoore.TabIndex = 5;
            this.btnMoore.Text = "Moore";
            this.btnMoore.UseVisualStyleBackColor = true;
            this.btnMoore.Click += new System.EventHandler(this.btnMoore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1167, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImportFile,
            this.menuImportBitmap});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // menuImportFile
            // 
            this.menuImportFile.Name = "menuImportFile";
            this.menuImportFile.Size = new System.Drawing.Size(143, 26);
            this.menuImportFile.Text = "Data File";
            this.menuImportFile.Click += new System.EventHandler(this.menuImportFile_Click);
            // 
            // menuImportBitmap
            // 
            this.menuImportBitmap.Name = "menuImportBitmap";
            this.menuImportBitmap.Size = new System.Drawing.Size(143, 26);
            this.menuImportBitmap.Text = "Bitmap";
            this.menuImportBitmap.Click += new System.EventHandler(this.menuImportBitmap_Click_1);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExportFile,
            this.menuExportBitmap});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // menuExportFile
            // 
            this.menuExportFile.Name = "menuExportFile";
            this.menuExportFile.Size = new System.Drawing.Size(141, 26);
            this.menuExportFile.Text = "Data file";
            this.menuExportFile.Click += new System.EventHandler(this.menuExportFile_Click);
            // 
            // menuExportBitmap
            // 
            this.menuExportBitmap.Name = "menuExportBitmap";
            this.menuExportBitmap.Size = new System.Drawing.Size(141, 26);
            this.menuExportBitmap.Text = "Bitmap";
            this.menuExportBitmap.Click += new System.EventHandler(this.menuExportBitmap_Click);
            // 
            // txtInclusionNumber
            // 
            this.txtInclusionNumber.Location = new System.Drawing.Point(704, 214);
            this.txtInclusionNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInclusionNumber.Name = "txtInclusionNumber";
            this.txtInclusionNumber.Size = new System.Drawing.Size(100, 22);
            this.txtInclusionNumber.TabIndex = 7;
            this.txtInclusionNumber.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Number of inclusions";
            // 
            // comboInclusionType
            // 
            this.comboInclusionType.FormattingEnabled = true;
            this.comboInclusionType.Items.AddRange(new object[] {
            "Dot",
            "Square",
            "Circle"});
            this.comboInclusionType.Location = new System.Drawing.Point(861, 214);
            this.comboInclusionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboInclusionType.Name = "comboInclusionType";
            this.comboInclusionType.Size = new System.Drawing.Size(100, 24);
            this.comboInclusionType.TabIndex = 8;
            this.comboInclusionType.Text = "Square";
            this.comboInclusionType.SelectedIndexChanged += new System.EventHandler(this.comboInclusionType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(856, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Size";
            // 
            // txtInclusionsSize
            // 
            this.txtInclusionsSize.Location = new System.Drawing.Point(861, 264);
            this.txtInclusionsSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtInclusionsSize.Name = "txtInclusionsSize";
            this.txtInclusionsSize.Size = new System.Drawing.Size(57, 22);
            this.txtInclusionsSize.TabIndex = 9;
            this.txtInclusionsSize.Text = "1";
            // 
            // btnGrainBoundaryShapeControl
            // 
            this.btnGrainBoundaryShapeControl.Location = new System.Drawing.Point(559, 285);
            this.btnGrainBoundaryShapeControl.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrainBoundaryShapeControl.Name = "btnGrainBoundaryShapeControl";
            this.btnGrainBoundaryShapeControl.Size = new System.Drawing.Size(133, 84);
            this.btnGrainBoundaryShapeControl.TabIndex = 10;
            this.btnGrainBoundaryShapeControl.Text = "Grain Boundary Shape Control";
            this.btnGrainBoundaryShapeControl.UseVisualStyleBackColor = true;
            this.btnGrainBoundaryShapeControl.Click += new System.EventHandler(this.btnGrainBoundaryShapeControl_Click);
            // 
            // btnCheckSizes
            // 
            this.btnCheckSizes.Location = new System.Drawing.Point(16, 540);
            this.btnCheckSizes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckSizes.Name = "btnCheckSizes";
            this.btnCheckSizes.Size = new System.Drawing.Size(87, 55);
            this.btnCheckSizes.TabIndex = 19;
            this.btnCheckSizes.Text = "Check % :";
            this.btnCheckSizes.UseVisualStyleBackColor = true;
            this.btnCheckSizes.Click += new System.EventHandler(this.btnCheckSizes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 537);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phases:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "% GB:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 583);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "% Inclusions:";
            // 
            // lblPhases
            // 
            this.lblPhases.AutoSize = true;
            this.lblPhases.Location = new System.Drawing.Point(219, 537);
            this.lblPhases.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhases.Name = "lblPhases";
            this.lblPhases.Size = new System.Drawing.Size(13, 17);
            this.lblPhases.TabIndex = 23;
            this.lblPhases.Text = "-";
            // 
            // lblGB
            // 
            this.lblGB.AutoSize = true;
            this.lblGB.Location = new System.Drawing.Point(219, 560);
            this.lblGB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGB.Name = "lblGB";
            this.lblGB.Size = new System.Drawing.Size(13, 17);
            this.lblGB.TabIndex = 24;
            this.lblGB.Text = "-";
            // 
            // lblInclusions
            // 
            this.lblInclusions.AutoSize = true;
            this.lblInclusions.Location = new System.Drawing.Point(219, 580);
            this.lblInclusions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInclusions.Name = "lblInclusions";
            this.lblInclusions.Size = new System.Drawing.Size(13, 17);
            this.lblInclusions.TabIndex = 25;
            this.lblInclusions.Text = "-";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(559, 444);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 84);
            this.button2.TabIndex = 12;
            this.button2.Text = "Detect Boundaries";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLeaveboundaries
            // 
            this.btnLeaveboundaries.Location = new System.Drawing.Point(701, 444);
            this.btnLeaveboundaries.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaveboundaries.Name = "btnLeaveboundaries";
            this.btnLeaveboundaries.Size = new System.Drawing.Size(100, 84);
            this.btnLeaveboundaries.TabIndex = 13;
            this.btnLeaveboundaries.Text = "Leave boundaries";
            this.btnLeaveboundaries.UseVisualStyleBackColor = true;
            this.btnLeaveboundaries.Click += new System.EventHandler(this.btnLeaveboundaries_Click);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(908, 503);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(37, 22);
            this.txtY.TabIndex = 15;
            this.txtY.Text = "150";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(861, 503);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(37, 22);
            this.txtX.TabIndex = 14;
            this.txtX.Text = "150";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(861, 480);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 17);
            this.label9.TabIndex = 30;
            this.label9.Text = "X:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(904, 480);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Y:";
            // 
            // btnCordinates
            // 
            this.btnCordinates.Location = new System.Drawing.Point(860, 444);
            this.btnCordinates.Margin = new System.Windows.Forms.Padding(4);
            this.btnCordinates.Name = "btnCordinates";
            this.btnCordinates.Size = new System.Drawing.Size(87, 28);
            this.btnCordinates.TabIndex = 32;
            this.btnCordinates.Text = "Cordinates";
            this.btnCordinates.UseVisualStyleBackColor = true;
            this.btnCordinates.Click += new System.EventHandler(this.btnCordinates_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(704, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "50";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(701, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "Probability (%)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtMCphases);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnMonteCarloBegin);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtMCiteration);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboMonteCarloP);
            this.groupBox1.Controls.Add(this.btnMonteCarlo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(988, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 489);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 249);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Dual Phase";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtMCphases
            // 
            this.txtMCphases.Location = new System.Drawing.Point(87, 121);
            this.txtMCphases.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCphases.Name = "txtMCphases";
            this.txtMCphases.Size = new System.Drawing.Size(52, 22);
            this.txtMCphases.TabIndex = 38;
            this.txtMCphases.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 36;
            this.label15.Text = "Phases";
            // 
            // btnMonteCarloBegin
            // 
            this.btnMonteCarloBegin.Location = new System.Drawing.Point(6, 150);
            this.btnMonteCarloBegin.Name = "btnMonteCarloBegin";
            this.btnMonteCarloBegin.Size = new System.Drawing.Size(133, 36);
            this.btnMonteCarloBegin.TabIndex = 37;
            this.btnMonteCarloBegin.Text = "Generate Points";
            this.btnMonteCarloBegin.UseVisualStyleBackColor = true;
            this.btnMonteCarloBegin.Click += new System.EventHandler(this.btnMonteCarloBegin_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 64);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 37;
            this.label14.Text = "Iteration";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 17);
            this.label13.TabIndex = 36;
            this.label13.Text = "Monte Carlo";
            // 
            // txtMCiteration
            // 
            this.txtMCiteration.Location = new System.Drawing.Point(87, 61);
            this.txtMCiteration.Margin = new System.Windows.Forms.Padding(4);
            this.txtMCiteration.Name = "txtMCiteration";
            this.txtMCiteration.Size = new System.Drawing.Size(52, 22);
            this.txtMCiteration.TabIndex = 36;
            this.txtMCiteration.Text = "3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 81);
            this.button1.TabIndex = 4;
            this.button1.Text = "DualPhase";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMonteCarloP
            // 
            this.comboMonteCarloP.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3",
            "0,4",
            "0,5",
            "0,6",
            "0,7",
            "0,8",
            "0,9",
            "1"});
            this.comboMonteCarloP.Location = new System.Drawing.Point(87, 90);
            this.comboMonteCarloP.Name = "comboMonteCarloP";
            this.comboMonteCarloP.Size = new System.Drawing.Size(52, 24);
            this.comboMonteCarloP.TabIndex = 3;
            this.comboMonteCarloP.Text = "1";
            // 
            // btnMonteCarlo
            // 
            this.btnMonteCarlo.Location = new System.Drawing.Point(6, 192);
            this.btnMonteCarlo.Name = "btnMonteCarlo";
            this.btnMonteCarlo.Size = new System.Drawing.Size(133, 36);
            this.btnMonteCarlo.TabIndex = 0;
            this.btnMonteCarlo.Text = "MonteCarlo";
            this.btnMonteCarlo.UseVisualStyleBackColor = true;
            this.btnMonteCarlo.Click += new System.EventHandler(this.btnMonteCarlo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "GB Energy";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Energy Distribution";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCordinates);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.btnLeaveboundaries);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblInclusions);
            this.Controls.Add(this.lblGB);
            this.Controls.Add(this.lblPhases);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCheckSizes);
            this.Controls.Add(this.btnGrainBoundaryShapeControl);
            this.Controls.Add(this.txtInclusionsSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboInclusionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInclusionNumber);
            this.Controls.Add(this.btnMoore);
            this.Controls.Add(this.btnVonNeumann);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtNumberOfColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberOfGrains);
            this.Controls.Add(this.btnRandomGrow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1185, 650);
            this.MinimumSize = new System.Drawing.Size(1085, 650);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRandomGrow;
        private System.Windows.Forms.TextBox txtNumberOfGrains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberOfColors;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnVonNeumann;
        private System.Windows.Forms.Button btnMoore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImportFile;
        private System.Windows.Forms.ToolStripMenuItem menuImportBitmap;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuExportFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportBitmap;
        private System.Windows.Forms.TextBox txtInclusionNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboInclusionType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInclusionsSize;
        private System.Windows.Forms.Button btnGrainBoundaryShapeControl;
        private System.Windows.Forms.Button btnCheckSizes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPhases;
        private System.Windows.Forms.Label lblGB;
        private System.Windows.Forms.Label lblInclusions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLeaveboundaries;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCordinates;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMonteCarlo;
        private System.Windows.Forms.ComboBox comboMonteCarloP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMCiteration;
        private System.Windows.Forms.Button btnMonteCarloBegin;
        private System.Windows.Forms.TextBox txtMCphases;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button3;
    }
}

