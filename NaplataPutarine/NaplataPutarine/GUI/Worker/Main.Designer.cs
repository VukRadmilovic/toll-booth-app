namespace NaplataPutarine.GUI.Worker
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
            this.uredjajiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uredjajiButton
            // 
            this.uredjajiButton.Location = new System.Drawing.Point(12, 12);
            this.uredjajiButton.Name = "uredjajiButton";
            this.uredjajiButton.Size = new System.Drawing.Size(326, 224);
            this.uredjajiButton.TabIndex = 0;
            this.uredjajiButton.Text = "Pregled uređaja";
            this.uredjajiButton.UseVisualStyleBackColor = true;
            this.uredjajiButton.Click += new System.EventHandler(this.UredjajiButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 248);
            this.Controls.Add(this.uredjajiButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "Radnik";
            this.ResumeLayout(false);

        }

        #endregion

        private Button uredjajiButton;
    }
}