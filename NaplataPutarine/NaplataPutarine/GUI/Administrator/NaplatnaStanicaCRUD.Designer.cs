namespace NaplataPutarine.GUI.Administrator
{
    partial class NaplatnaStanicaCRUD
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
            this.label2 = new System.Windows.Forms.Label();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.staniceTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzgradnje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mestoTextBox = new System.Windows.Forms.TextBox();
            this.izgradnjaDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dodajButton = new System.Windows.Forms.Button();
            this.azurirajButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.mestaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.staniceTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(99, 14);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(215, 23);
            this.nazivTextBox.TabIndex = 3;
            // 
            // staniceTable
            // 
            this.staniceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staniceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Naziv,
            this.Mesto,
            this.DatumIzgradnje});
            this.staniceTable.Location = new System.Drawing.Point(12, 115);
            this.staniceTable.MultiSelect = false;
            this.staniceTable.Name = "staniceTable";
            this.staniceTable.ReadOnly = true;
            this.staniceTable.RowTemplate.Height = 25;
            this.staniceTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.staniceTable.Size = new System.Drawing.Size(640, 323);
            this.staniceTable.TabIndex = 4;
            this.staniceTable.SelectionChanged += new System.EventHandler(this.StaniceTable_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 150;
            // 
            // Mesto
            // 
            this.Mesto.HeaderText = "Mesto";
            this.Mesto.Name = "Mesto";
            this.Mesto.ReadOnly = true;
            this.Mesto.Width = 150;
            // 
            // DatumIzgradnje
            // 
            this.DatumIzgradnje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzgradnje.HeaderText = "Datum izgradnje";
            this.DatumIzgradnje.Name = "DatumIzgradnje";
            this.DatumIzgradnje.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum izgradnje:";
            // 
            // mestoTextBox
            // 
            this.mestoTextBox.Location = new System.Drawing.Point(378, 14);
            this.mestoTextBox.Name = "mestoTextBox";
            this.mestoTextBox.Size = new System.Drawing.Size(215, 23);
            this.mestoTextBox.TabIndex = 7;
            // 
            // izgradnjaDatePicker
            // 
            this.izgradnjaDatePicker.Location = new System.Drawing.Point(320, 47);
            this.izgradnjaDatePicker.Name = "izgradnjaDatePicker";
            this.izgradnjaDatePicker.Size = new System.Drawing.Size(145, 23);
            this.izgradnjaDatePicker.TabIndex = 8;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(14, 77);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(155, 23);
            this.dodajButton.TabIndex = 9;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // azurirajButton
            // 
            this.azurirajButton.Location = new System.Drawing.Point(175, 77);
            this.azurirajButton.Name = "azurirajButton";
            this.azurirajButton.Size = new System.Drawing.Size(155, 23);
            this.azurirajButton.TabIndex = 10;
            this.azurirajButton.Text = "Ažuriraj";
            this.azurirajButton.UseVisualStyleBackColor = true;
            this.azurirajButton.Click += new System.EventHandler(this.AzurirajButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(336, 77);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(155, 23);
            this.obrisiButton.TabIndex = 11;
            this.obrisiButton.Text = "Obriši";
            this.obrisiButton.UseVisualStyleBackColor = true;
            this.obrisiButton.Click += new System.EventHandler(this.ObrisiButton_Click);
            // 
            // mestaButton
            // 
            this.mestaButton.Location = new System.Drawing.Point(497, 77);
            this.mestaButton.Name = "mestaButton";
            this.mestaButton.Size = new System.Drawing.Size(155, 23);
            this.mestaButton.TabIndex = 12;
            this.mestaButton.Text = "Vidi naplatna mesta";
            this.mestaButton.UseVisualStyleBackColor = true;
            this.mestaButton.Click += new System.EventHandler(this.MestaButton_Click);
            // 
            // NaplatnaStanicaCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.mestaButton);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.azurirajButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.izgradnjaDatePicker);
            this.Controls.Add(this.mestoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staniceTable);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.label2);
            this.Name = "NaplatnaStanicaCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naplatne stanice";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NaplatnaStanicaCRUD_FormClosed);
            this.Load += new System.EventHandler(this.NaplatnaStanicaCRUD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.staniceTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox nazivTextBox;
        private DataGridView staniceTable;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Naziv;
        private DataGridViewTextBoxColumn Mesto;
        private DataGridViewTextBoxColumn DatumIzgradnje;
        private Label label3;
        private Label label4;
        private TextBox mestoTextBox;
        private DateTimePicker izgradnjaDatePicker;
        private Button dodajButton;
        private Button azurirajButton;
        private Button obrisiButton;
        private Button mestaButton;
    }
}