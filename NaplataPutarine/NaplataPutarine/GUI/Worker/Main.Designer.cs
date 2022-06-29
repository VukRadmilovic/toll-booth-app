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
            this.paymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uredjajiButton
            // 
            this.uredjajiButton.Location = new System.Drawing.Point(14, 16);
            this.uredjajiButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uredjajiButton.Name = "uredjajiButton";
            this.uredjajiButton.Size = new System.Drawing.Size(374, 141);
            this.uredjajiButton.TabIndex = 0;
            this.uredjajiButton.Text = "Pregled uređaja";
            this.uredjajiButton.UseVisualStyleBackColor = true;
            this.uredjajiButton.Click += new System.EventHandler(this.UredjajiButton_Click);
            // 
            // paymentButton
            // 
            this.paymentButton.Location = new System.Drawing.Point(14, 164);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Size = new System.Drawing.Size(374, 141);
            this.paymentButton.TabIndex = 1;
            this.paymentButton.Text = "Fizicka naplata";
            this.paymentButton.UseVisualStyleBackColor = true;
            this.paymentButton.Click += new System.EventHandler(this.paymentButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 331);
            this.Controls.Add(this.paymentButton);
            this.Controls.Add(this.uredjajiButton);
            this.Name = "Main";
            this.Text = "Radnik";
            this.ResumeLayout(false);

        }

        #endregion

        private Button uredjajiButton;
        private Button paymentButton;
    }
}