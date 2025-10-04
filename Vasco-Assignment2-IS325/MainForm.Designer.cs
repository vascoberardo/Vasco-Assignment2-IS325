namespace Vasco_Assignment2_IS325
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMakeModel = new Label();
            lstMakeModel = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            grpFeatures = new GroupBox();
            chkLaneAssist = new CheckBox();
            chkAC = new CheckBox();
            chkSiriusRadio = new CheckBox();
            chkPowerWindows = new CheckBox();
            grpColor = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radWhite = new RadioButton();
            radYellow = new RadioButton();
            lblOutput = new Label();
            btnPurchase = new Button();
            grpFeatures.SuspendLayout();
            grpColor.SuspendLayout();
            SuspendLayout();
            // 
            // lblMakeModel
            // 
            lblMakeModel.AutoSize = true;
            lblMakeModel.Location = new Point(105, 105);
            lblMakeModel.Name = "lblMakeModel";
            lblMakeModel.Size = new Size(96, 15);
            lblMakeModel.TabIndex = 0;
            lblMakeModel.Text = "&Make and Model";
            // 
            // lstMakeModel
            // 
            lstMakeModel.FormattingEnabled = true;
            lstMakeModel.ItemHeight = 15;
            lstMakeModel.Items.AddRange(new object[] { "Chevrolet Silverado", "Ford F-150", "Toyota Yaris", "Honda Civic", "Porsche Panamera" });
            lstMakeModel.Location = new Point(105, 123);
            lstMakeModel.Name = "lstMakeModel";
            lstMakeModel.Size = new Size(120, 94);
            lstMakeModel.TabIndex = 1;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(299, 105);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(29, 15);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(299, 123);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 3;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkLaneAssist);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Controls.Add(chkSiriusRadio);
            grpFeatures.Controls.Add(chkPowerWindows);
            grpFeatures.Location = new Point(652, 90);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(117, 167);
            grpFeatures.TabIndex = 5;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkLaneAssist
            // 
            chkLaneAssist.AutoSize = true;
            chkLaneAssist.Location = new Point(6, 105);
            chkLaneAssist.Name = "chkLaneAssist";
            chkLaneAssist.Size = new Size(109, 19);
            chkLaneAssist.TabIndex = 3;
            chkLaneAssist.Text = "Lane Assistance";
            chkLaneAssist.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(6, 26);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(42, 19);
            chkAC.TabIndex = 0;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // chkSiriusRadio
            // 
            chkSiriusRadio.AutoSize = true;
            chkSiriusRadio.Location = new Point(6, 80);
            chkSiriusRadio.Name = "chkSiriusRadio";
            chkSiriusRadio.Size = new Size(87, 19);
            chkSiriusRadio.TabIndex = 2;
            chkSiriusRadio.Text = "Sirius Radio";
            chkSiriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(6, 55);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(111, 19);
            chkPowerWindows.TabIndex = 1;
            chkPowerWindows.Text = "Power Windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radWhite);
            grpColor.Controls.Add(radYellow);
            grpColor.Location = new Point(497, 90);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(124, 167);
            grpColor.TabIndex = 4;
            grpColor.TabStop = false;
            grpColor.Text = "&Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(6, 58);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(53, 19);
            radBlack.TabIndex = 1;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(6, 33);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(48, 19);
            radBlue.TabIndex = 0;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(6, 86);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(56, 19);
            radWhite.TabIndex = 2;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            radWhite.CheckedChanged += radWhite_CheckedChanged;
            // 
            // radYellow
            // 
            radYellow.AutoSize = true;
            radYellow.Location = new Point(6, 111);
            radYellow.Name = "radYellow";
            radYellow.Size = new Size(59, 19);
            radYellow.TabIndex = 3;
            radYellow.TabStop = true;
            radYellow.Text = "Yellow";
            radYellow.UseVisualStyleBackColor = true;
            radYellow.CheckedChanged += radYellow_CheckedChanged;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(252, 339);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(488, 75);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "Output";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(126, 339);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 6;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPurchase);
            Controls.Add(lblOutput);
            Controls.Add(grpColor);
            Controls.Add(grpFeatures);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstMakeModel);
            Controls.Add(lblMakeModel);
            Name = "MainForm";
            Text = "Assignment 2";
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMakeModel;
        private ListBox lstMakeModel;
        private Label lblYear;
        private TextBox txtYear;
        private GroupBox grpFeatures;
        private CheckBox chkAC;
        private GroupBox grpColor;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private Label lblOutput;
        private Button btnPurchase;
        private RadioButton radWhite;
        private RadioButton radYellow;
        private CheckBox chkPowerWindows;
        private CheckBox chkSiriusRadio;
        private CheckBox chkLaneAssist;
    }
}
