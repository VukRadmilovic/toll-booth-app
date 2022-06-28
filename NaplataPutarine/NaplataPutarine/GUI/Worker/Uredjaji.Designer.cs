namespace NaplataPutarine.GUI.Worker
{
    partial class Uredjaji
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uredjajiTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipUredjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispravan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.promeniStatusButton = new System.Windows.Forms.Button();
            this.ispravanRadioButton = new System.Windows.Forms.RadioButton();
            this.neispravanRadioButton = new System.Windows.Forms.RadioButton();
            this.ispravnostGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.uredjajiTable)).BeginInit();
            this.ispravnostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // uredjajiTable
            // 
            this.uredjajiTable.AllowUserToAddRows = false;
            this.uredjajiTable.AllowUserToDeleteRows = false;
            this.uredjajiTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uredjajiTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.uredjajiTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uredjajiTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipUredjaja,
            this.NMID,
            this.Ispravan});
            this.uredjajiTable.Location = new System.Drawing.Point(12, 11);
            this.uredjajiTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uredjajiTable.Name = "uredjajiTable";
            this.uredjajiTable.ReadOnly = true;
            this.uredjajiTable.RowHeadersWidth = 51;
            this.uredjajiTable.RowTemplate.Height = 35;
            this.uredjajiTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uredjajiTable.Size = new System.Drawing.Size(617, 317);
            this.uredjajiTable.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID uređaja";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TipUredjaja
            // 
            this.TipUredjaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipUredjaja.HeaderText = "Tip uređaja";
            this.TipUredjaja.MinimumWidth = 6;
            this.TipUredjaja.Name = "TipUredjaja";
            this.TipUredjaja.ReadOnly = true;
            // 
            // NMID
            // 
            this.NMID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NMID.HeaderText = "Naplatno mesto";
            this.NMID.MinimumWidth = 6;
            this.NMID.Name = "NMID";
            this.NMID.ReadOnly = true;
            // 
            // Ispravan
            // 
            this.Ispravan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispravan.HeaderText = "Ispravan";
            this.Ispravan.MinimumWidth = 6;
            this.Ispravan.Name = "Ispravan";
            this.Ispravan.ReadOnly = true;
            // 
            // promeniStatusButton
            // 
            this.promeniStatusButton.Location = new System.Drawing.Point(328, 345);
            this.promeniStatusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.promeniStatusButton.Name = "promeniStatusButton";
            this.promeniStatusButton.Size = new System.Drawing.Size(184, 35);
            this.promeniStatusButton.TabIndex = 2;
            this.promeniStatusButton.Text = "Promeni status uređaja";
            this.promeniStatusButton.UseVisualStyleBackColor = true;
            this.promeniStatusButton.Click += new System.EventHandler(this.PromeniStatusButton_Click);
            // 
            // ispravanRadioButton
            // 
            this.ispravanRadioButton.AutoSize = true;
            this.ispravanRadioButton.Checked = true;
            this.ispravanRadioButton.Location = new System.Drawing.Point(15, 20);
            this.ispravanRadioButton.Name = "ispravanRadioButton";
            this.ispravanRadioButton.Size = new System.Drawing.Size(69, 19);
            this.ispravanRadioButton.TabIndex = 3;
            this.ispravanRadioButton.TabStop = true;
            this.ispravanRadioButton.Text = "Ispravan";
            this.ispravanRadioButton.UseVisualStyleBackColor = true;
            // 
            // neispravanRadioButton
            // 
            this.neispravanRadioButton.AutoSize = true;
            this.neispravanRadioButton.Location = new System.Drawing.Point(90, 20);
            this.neispravanRadioButton.Name = "neispravanRadioButton";
            this.neispravanRadioButton.Size = new System.Drawing.Size(84, 19);
            this.neispravanRadioButton.TabIndex = 4;
            this.neispravanRadioButton.TabStop = true;
            this.neispravanRadioButton.Text = "Neispravan";
            this.neispravanRadioButton.UseVisualStyleBackColor = true;
            // 
            // ispravnostGroupBox
            // 
            this.ispravnostGroupBox.Controls.Add(this.ispravanRadioButton);
            this.ispravnostGroupBox.Controls.Add(this.neispravanRadioButton);
            this.ispravnostGroupBox.Location = new System.Drawing.Point(108, 333);
            this.ispravnostGroupBox.Name = "ispravnostGroupBox";
            this.ispravnostGroupBox.Size = new System.Drawing.Size(183, 47);
            this.ispravnostGroupBox.TabIndex = 5;
            this.ispravnostGroupBox.TabStop = false;
            this.ispravnostGroupBox.Text = "Ispravnost";
            // 
            // Uredjaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 394);
            this.Controls.Add(this.ispravnostGroupBox);
            this.Controls.Add(this.promeniStatusButton);
            this.Controls.Add(this.uredjajiTable);
            this.Name = "Uredjaji";
            this.Text = "Uređaji";
            this.Load += new System.EventHandler(this.Uredjaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uredjajiTable)).EndInit();
            this.ispravnostGroupBox.ResumeLayout(false);
            this.ispravnostGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView uredjajiTable;
        private Button promeniStatusButton;
        private RadioButton ispravanRadioButton;
        private RadioButton neispravanRadioButton;
        private GroupBox ispravnostGroupBox;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TipUredjaja;
        private DataGridViewTextBoxColumn NMID;
        private DataGridViewCheckBoxColumn Ispravan;
    }
}