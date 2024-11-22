namespace TollBoothApp.GUI.Worker
{
    partial class PhysicalPayment
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
            this.vremeBox = new System.Windows.Forms.TextBox();
            this.mestoBox = new System.Windows.Forms.TextBox();
            this.kursBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catCombo = new System.Windows.Forms.ComboBox();
            this.kursButton = new System.Windows.Forms.Button();
            this.speedButton = new System.Windows.Forms.Button();
            this.brLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uredjajLabel = new System.Windows.Forms.Label();
            this.rampLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vremeBox
            // 
            this.vremeBox.Enabled = false;
            this.vremeBox.Location = new System.Drawing.Point(191, 26);
            this.vremeBox.Name = "vremeBox";
            this.vremeBox.Size = new System.Drawing.Size(151, 27);
            this.vremeBox.TabIndex = 0;
            // 
            // mestoBox
            // 
            this.mestoBox.Enabled = false;
            this.mestoBox.Location = new System.Drawing.Point(191, 68);
            this.mestoBox.Name = "mestoBox";
            this.mestoBox.Size = new System.Drawing.Size(151, 27);
            this.mestoBox.TabIndex = 1;
            // 
            // kursBox
            // 
            this.kursBox.Enabled = false;
            this.kursBox.Location = new System.Drawing.Point(191, 199);
            this.kursBox.Name = "kursBox";
            this.kursBox.Size = new System.Drawing.Size(151, 27);
            this.kursBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vreme ulaska vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Stanice ulaska vozila";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategorija vozila";
            // 
            // catCombo
            // 
            this.catCombo.FormattingEnabled = true;
            this.catCombo.Location = new System.Drawing.Point(191, 113);
            this.catCombo.Name = "catCombo";
            this.catCombo.Size = new System.Drawing.Size(151, 28);
            this.catCombo.TabIndex = 7;
            // 
            // kursButton
            // 
            this.kursButton.Location = new System.Drawing.Point(34, 331);
            this.kursButton.Name = "kursButton";
            this.kursButton.Size = new System.Drawing.Size(138, 78);
            this.kursButton.TabIndex = 8;
            this.kursButton.Text = "Racunanje kursa";
            this.kursButton.UseVisualStyleBackColor = true;
            this.kursButton.Click += new System.EventHandler(this.kursButton_Click);
            // 
            // speedButton
            // 
            this.speedButton.Location = new System.Drawing.Point(229, 331);
            this.speedButton.Name = "speedButton";
            this.speedButton.Size = new System.Drawing.Size(138, 78);
            this.speedButton.TabIndex = 9;
            this.speedButton.Text = "Provera prosecne brzine";
            this.speedButton.UseVisualStyleBackColor = true;
            this.speedButton.Click += new System.EventHandler(this.speedButton_Click);
            // 
            // brLabel
            // 
            this.brLabel.AutoSize = true;
            this.brLabel.Location = new System.Drawing.Point(11, 42);
            this.brLabel.Name = "brLabel";
            this.brLabel.Size = new System.Drawing.Size(92, 20);
            this.brLabel.TabIndex = 10;
            this.brLabel.Text = "Broj tablice: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uredjajLabel);
            this.groupBox1.Controls.Add(this.rampLabel);
            this.groupBox1.Controls.Add(this.brLabel);
            this.groupBox1.Location = new System.Drawing.Point(447, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 168);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Indikatori";
            // 
            // uredjajLabel
            // 
            this.uredjajLabel.AutoSize = true;
            this.uredjajLabel.Location = new System.Drawing.Point(11, 126);
            this.uredjajLabel.Name = "uredjajLabel";
            this.uredjajLabel.Size = new System.Drawing.Size(141, 20);
            this.uredjajLabel.TabIndex = 12;
            this.uredjajLabel.Text = "Ispravnost uredjaja: ";
            // 
            // rampLabel
            // 
            this.rampLabel.AutoSize = true;
            this.rampLabel.Location = new System.Drawing.Point(11, 87);
            this.rampLabel.Name = "rampLabel";
            this.rampLabel.Size = new System.Drawing.Size(103, 20);
            this.rampLabel.TabIndex = 11;
            this.rampLabel.Text = "Status rampe: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Kurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Prosecna brzina";
            // 
            // speedBox
            // 
            this.speedBox.Enabled = false;
            this.speedBox.Location = new System.Drawing.Point(191, 242);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(151, 27);
            this.speedBox.TabIndex = 13;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(423, 331);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(138, 78);
            this.nextButton.TabIndex = 16;
            this.nextButton.Text = "Sledeci";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // PhysicalPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.speedButton);
            this.Controls.Add(this.kursButton);
            this.Controls.Add(this.catCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kursBox);
            this.Controls.Add(this.mestoBox);
            this.Controls.Add(this.vremeBox);
            this.Name = "PhysicalPayment";
            this.Text = "PhysicalPayment";
            this.Load += new System.EventHandler(this.PhysicalPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox vremeBox;
        private TextBox mestoBox;
        private TextBox kursBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox catCombo;
        private Button kursButton;
        private Button speedButton;
        private Label brLabel;
        private GroupBox groupBox1;
        private Label uredjajLabel;
        private Label rampLabel;
        private Label label7;
        private Label label8;
        private TextBox speedBox;
        private Button nextButton;
    }
}