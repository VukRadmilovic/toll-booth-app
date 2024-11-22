namespace TollBoothApp.GUI.GeneralManager
{
    partial class PricelistCheck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrednost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricelistTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipUredjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PricelistTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID  deonice";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.MinimumWidth = 6;
            this.Kategorija.Name = "Kategorija";
            // 
            // Vrednost
            // 
            this.Vrednost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vrednost.HeaderText = "Vrednost";
            this.Vrednost.MinimumWidth = 6;
            this.Vrednost.Name = "Vrednost";
            // 
            // PricelistTable
            // 
            this.PricelistTable.AllowUserToAddRows = false;
            this.PricelistTable.AllowUserToDeleteRows = false;
            this.PricelistTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PricelistTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PricelistTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PricelistTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.TipUredjaja,
            this.NMID,
            this.Column1});
            this.PricelistTable.Location = new System.Drawing.Point(16, 38);
            this.PricelistTable.Name = "PricelistTable";
            this.PricelistTable.RowHeadersWidth = 51;
            this.PricelistTable.RowTemplate.Height = 35;
            this.PricelistTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PricelistTable.Size = new System.Drawing.Size(768, 374);
            this.PricelistTable.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Deonica";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // TipUredjaja
            // 
            this.TipUredjaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipUredjaja.HeaderText = "Kategorija";
            this.TipUredjaja.MinimumWidth = 6;
            this.TipUredjaja.Name = "TipUredjaja";
            // 
            // NMID
            // 
            this.NMID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NMID.HeaderText = "Vrednost";
            this.NMID.MinimumWidth = 6;
            this.NMID.Name = "NMID";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Datum Kreiranja";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // PricelistCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PricelistTable);
            this.Name = "PricelistCheck";
            this.Text = "PricelistCheck";
            this.Load += new System.EventHandler(this.PricelistCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PricelistTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Kategorija;
        private DataGridViewTextBoxColumn Vrednost;
        private DataGridView PricelistTable;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TipUredjaja;
        private DataGridViewTextBoxColumn NMID;
        private DataGridViewTextBoxColumn Column1;
    }
}