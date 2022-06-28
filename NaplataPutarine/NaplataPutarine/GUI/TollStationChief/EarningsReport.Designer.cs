namespace NaplataPutarine.GUI.TollStationChief.Forms
{
    partial class EarningsReport
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
            this.reportTextArea = new System.Windows.Forms.RichTextBox();
            this.periodGroup = new System.Windows.Forms.GroupBox();
            this.yearPicker = new System.Windows.Forms.NumericUpDown();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.monthPicker = new System.Windows.Forms.ComboBox();
            this.monthRadioButton = new System.Windows.Forms.RadioButton();
            this.dayPicker = new System.Windows.Forms.DateTimePicker();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.showButton = new System.Windows.Forms.Button();
            this.periodGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // reportTextArea
            // 
            this.reportTextArea.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportTextArea.Location = new System.Drawing.Point(21, 20);
            this.reportTextArea.Name = "reportTextArea";
            this.reportTextArea.Size = new System.Drawing.Size(458, 458);
            this.reportTextArea.TabIndex = 0;
            this.reportTextArea.Text = "";
            // 
            // periodGroup
            // 
            this.periodGroup.Controls.Add(this.showButton);
            this.periodGroup.Controls.Add(this.yearPicker);
            this.periodGroup.Controls.Add(this.yearRadioButton);
            this.periodGroup.Controls.Add(this.monthPicker);
            this.periodGroup.Controls.Add(this.monthRadioButton);
            this.periodGroup.Controls.Add(this.dayPicker);
            this.periodGroup.Controls.Add(this.dayRadioButton);
            this.periodGroup.Location = new System.Drawing.Point(512, 20);
            this.periodGroup.Name = "periodGroup";
            this.periodGroup.Size = new System.Drawing.Size(367, 458);
            this.periodGroup.TabIndex = 1;
            this.periodGroup.TabStop = false;
            this.periodGroup.Text = "Period";
            // 
            // yearPicker
            // 
            this.yearPicker.Enabled = false;
            this.yearPicker.Location = new System.Drawing.Point(62, 325);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Size = new System.Drawing.Size(250, 27);
            this.yearPicker.TabIndex = 5;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Location = new System.Drawing.Point(149, 278);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(78, 24);
            this.yearRadioButton.TabIndex = 4;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "Godina";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            this.yearRadioButton.CheckedChanged += new System.EventHandler(this.YearRadioButton_CheckedChanged);
            // 
            // monthPicker
            // 
            this.monthPicker.Enabled = false;
            this.monthPicker.FormattingEnabled = true;
            this.monthPicker.Location = new System.Drawing.Point(62, 193);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(250, 28);
            this.monthPicker.TabIndex = 3;
            // 
            // monthRadioButton
            // 
            this.monthRadioButton.AutoSize = true;
            this.monthRadioButton.Location = new System.Drawing.Point(149, 149);
            this.monthRadioButton.Name = "monthRadioButton";
            this.monthRadioButton.Size = new System.Drawing.Size(72, 24);
            this.monthRadioButton.TabIndex = 2;
            this.monthRadioButton.TabStop = true;
            this.monthRadioButton.Text = "Mesec";
            this.monthRadioButton.UseVisualStyleBackColor = true;
            this.monthRadioButton.CheckedChanged += new System.EventHandler(this.MonthRadioButton_CheckedChanged);
            // 
            // dayPicker
            // 
            this.dayPicker.Enabled = false;
            this.dayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dayPicker.Location = new System.Drawing.Point(62, 75);
            this.dayPicker.Name = "dayPicker";
            this.dayPicker.Size = new System.Drawing.Size(250, 27);
            this.dayPicker.TabIndex = 1;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(149, 36);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(57, 24);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.TabStop = true;
            this.dayRadioButton.Text = "Dan";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            this.dayRadioButton.CheckedChanged += new System.EventHandler(this.DayRadioButton_CheckedChanged);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(149, 401);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(94, 29);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Prikaži";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // EarningsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 503);
            this.Controls.Add(this.periodGroup);
            this.Controls.Add(this.reportTextArea);
            this.Name = "EarningsReport";
            this.Text = "Finansijski izveštaj";
            this.Load += new System.EventHandler(this.EarningsReport_Load);
            this.periodGroup.ResumeLayout(false);
            this.periodGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yearPicker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox reportTextArea;
        private GroupBox periodGroup;
        private NumericUpDown yearPicker;
        private RadioButton yearRadioButton;
        private ComboBox monthPicker;
        private RadioButton monthRadioButton;
        private DateTimePicker dayPicker;
        private RadioButton dayRadioButton;
        private Button showButton;
    }
}