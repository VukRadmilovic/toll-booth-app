namespace NaplataPutarine.GUI.TollStationChief
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
            this.deviceStateButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stationInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deviceStateButton
            // 
            this.deviceStateButton.Location = new System.Drawing.Point(26, 83);
            this.deviceStateButton.Name = "deviceStateButton";
            this.deviceStateButton.Size = new System.Drawing.Size(224, 29);
            this.deviceStateButton.TabIndex = 0;
            this.deviceStateButton.Text = "Pregled stanja uređaja";
            this.deviceStateButton.UseVisualStyleBackColor = true;
            this.deviceStateButton.Click += new System.EventHandler(this.DeviceStateButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(26, 141);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(224, 29);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "Izveštaj o prihodima stanice";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lični podaci";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // stationInfo
            // 
            this.stationInfo.AutoSize = true;
            this.stationInfo.Location = new System.Drawing.Point(26, 29);
            this.stationInfo.Name = "stationInfo";
            this.stationInfo.Size = new System.Drawing.Size(0, 20);
            this.stationInfo.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 268);
            this.Controls.Add(this.stationInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.deviceStateButton);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deviceStateButton;
        private Button reportButton;
        private Button button1;
        private Label stationInfo;
    }
}