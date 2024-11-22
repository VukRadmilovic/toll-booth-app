namespace TollBoothApp.GUI.TollStationChief
{
    partial class DeviceStates
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
            this.deviceStatusTable = new System.Windows.Forms.DataGridView();
            this.fixButton = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipUredjaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ispravan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusTable)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceStatusTable
            // 
            this.deviceStatusTable.AllowUserToAddRows = false;
            this.deviceStatusTable.AllowUserToDeleteRows = false;
            this.deviceStatusTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.deviceStatusTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.deviceStatusTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceStatusTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TipUredjaja,
            this.NMID,
            this.Ispravan});
            this.deviceStatusTable.Location = new System.Drawing.Point(20, 17);
            this.deviceStatusTable.Name = "deviceStatusTable";
            this.deviceStatusTable.RowHeadersWidth = 51;
            this.deviceStatusTable.RowTemplate.Height = 35;
            this.deviceStatusTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceStatusTable.Size = new System.Drawing.Size(768, 374);
            this.deviceStatusTable.TabIndex = 0;
            this.deviceStatusTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviceStatusTable_CellClick);
            // 
            // fixButton
            // 
            this.fixButton.Enabled = false;
            this.fixButton.Location = new System.Drawing.Point(353, 408);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(94, 29);
            this.fixButton.TabIndex = 1;
            this.fixButton.Text = "Popravi";
            this.fixButton.UseVisualStyleBackColor = true;
            this.fixButton.Click += new System.EventHandler(this.FixButton_Click);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID  uređaja";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // TipUredjaja
            // 
            this.TipUredjaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipUredjaja.HeaderText = "Tip uređaja";
            this.TipUredjaja.MinimumWidth = 6;
            this.TipUredjaja.Name = "TipUredjaja";
            // 
            // NMID
            // 
            this.NMID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NMID.HeaderText = "Naplatno mesto";
            this.NMID.MinimumWidth = 6;
            this.NMID.Name = "NMID";
            // 
            // Ispravan
            // 
            this.Ispravan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ispravan.HeaderText = "Ispravan";
            this.Ispravan.MinimumWidth = 6;
            this.Ispravan.Name = "Ispravan";
            // 
            // DeviceStates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 461);
            this.Controls.Add(this.fixButton);
            this.Controls.Add(this.deviceStatusTable);
            this.Name = "DeviceStates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provera ispravnosti uređaja";
            this.Load += new System.EventHandler(this.DeviceStates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deviceStatusTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView deviceStatusTable;
        private Button fixButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TipUredjaja;
        private DataGridViewTextBoxColumn NMID;
        private DataGridViewCheckBoxColumn Ispravan;
    }
}