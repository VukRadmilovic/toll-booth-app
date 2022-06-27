namespace NaplataPutarine.GUI.GeneralManager
{
    partial class Main
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
            this.earningsReportButton = new System.Windows.Forms.Button();
            this.personalInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earningsReportButton
            // 
            this.earningsReportButton.Location = new System.Drawing.Point(28, 51);
            this.earningsReportButton.Name = "earningsReportButton";
            this.earningsReportButton.Size = new System.Drawing.Size(249, 29);
            this.earningsReportButton.TabIndex = 0;
            this.earningsReportButton.Text = "Izveštaj o prihodima svih stanica";
            this.earningsReportButton.UseVisualStyleBackColor = true;
            this.earningsReportButton.Click += new System.EventHandler(this.EarningsReportButton_Click);
            // 
            // personalInfoButton
            // 
            this.personalInfoButton.Location = new System.Drawing.Point(28, 105);
            this.personalInfoButton.Name = "personalInfoButton";
            this.personalInfoButton.Size = new System.Drawing.Size(249, 29);
            this.personalInfoButton.TabIndex = 1;
            this.personalInfoButton.Text = "Lični podaci";
            this.personalInfoButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 192);
            this.Controls.Add(this.personalInfoButton);
            this.Controls.Add(this.earningsReportButton);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Button earningsReportButton;
        private Button personalInfoButton;
    }
}