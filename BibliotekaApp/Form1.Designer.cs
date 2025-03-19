namespace BibliotekaApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTytul;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.TextBox txtSzukaj;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnWypozycz;
        private System.Windows.Forms.Button btnZwrot;
        private System.Windows.Forms.Label lblWitaj;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvKsiazki = new System.Windows.Forms.DataGridView();
            this.ksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDBDataSet = new BibliotekaApp.BibliotekaDBDataSet();
            this.txtTytul = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.txtSzukaj = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnWypozycz = new System.Windows.Forms.Button();
            this.btnZwrot = new System.Windows.Forms.Button();
            this.lblWitaj = new System.Windows.Forms.Label();
            this.ksiazkiTableAdapter = new BibliotekaApp.BibliotekaDBDataSetTableAdapters.KsiazkiTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tytul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RokWydania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dostepnosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zaznacz = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKsiazki
            // 
            this.dgvKsiazki.AutoGenerateColumns = false;
            this.dgvKsiazki.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKsiazki.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tytul,
            this.Autor,
            this.RokWydania,
            this.Dostepnosc,
            this.Zaznacz});
            this.dgvKsiazki.DataSource = this.ksiazkiBindingSource;
            this.dgvKsiazki.Location = new System.Drawing.Point(50, 80);
            this.dgvKsiazki.Name = "dgvKsiazki";
            this.dgvKsiazki.RowHeadersVisible = false;
            this.dgvKsiazki.RowHeadersWidth = 51;
            this.dgvKsiazki.Size = new System.Drawing.Size(772, 200);
            this.dgvKsiazki.TabIndex = 0;
            // 
            // ksiazkiBindingSource
            // 
            this.ksiazkiBindingSource.DataMember = "Ksiazki";
            this.ksiazkiBindingSource.DataSource = this.bibliotekaDBDataSet;
            // 
            // bibliotekaDBDataSet
            // 
            this.bibliotekaDBDataSet.DataSetName = "BibliotekaDBDataSet";
            this.bibliotekaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTytul
            // 
            this.txtTytul.Location = new System.Drawing.Point(0, 0);
            this.txtTytul.Name = "txtTytul";
            this.txtTytul.Size = new System.Drawing.Size(100, 22);
            this.txtTytul.TabIndex = 0;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(0, 0);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 22);
            this.txtAutor.TabIndex = 0;
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(0, 0);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(100, 22);
            this.txtRok.TabIndex = 0;
            // 
            // txtSzukaj
            // 
            this.txtSzukaj.Location = new System.Drawing.Point(0, 0);
            this.txtSzukaj.Name = "txtSzukaj";
            this.txtSzukaj.Size = new System.Drawing.Size(100, 22);
            this.txtSzukaj.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(828, 80);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Location = new System.Drawing.Point(828, 136);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(75, 23);
            this.btnUsun.TabIndex = 2;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnWypozycz
            // 
            this.btnWypozycz.Location = new System.Drawing.Point(828, 212);
            this.btnWypozycz.Name = "btnWypozycz";
            this.btnWypozycz.Size = new System.Drawing.Size(75, 23);
            this.btnWypozycz.TabIndex = 3;
            this.btnWypozycz.Text = "Wypożycz";
            this.btnWypozycz.Click += new System.EventHandler(this.btnWypozycz_Click);
            // 
            // btnZwrot
            // 
            this.btnZwrot.Location = new System.Drawing.Point(828, 257);
            this.btnZwrot.Name = "btnZwrot";
            this.btnZwrot.Size = new System.Drawing.Size(75, 23);
            this.btnZwrot.TabIndex = 4;
            this.btnZwrot.Text = "Zwrot";
            this.btnZwrot.Click += new System.EventHandler(this.btnZwrot_Click);
            // 
            // lblWitaj
            // 
            this.lblWitaj.Location = new System.Drawing.Point(0, 0);
            this.lblWitaj.Name = "lblWitaj";
            this.lblWitaj.Size = new System.Drawing.Size(100, 23);
            this.lblWitaj.TabIndex = 0;
            // 
            // ksiazkiTableAdapter
            // 
            this.ksiazkiTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 47;
            // 
            // Tytul
            // 
            this.Tytul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tytul.DataPropertyName = "Tytul";
            this.Tytul.HeaderText = "Tytul";
            this.Tytul.MinimumWidth = 6;
            this.Tytul.Name = "Tytul";
            // 
            // Autor
            // 
            this.Autor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autor.DataPropertyName = "Autor";
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            // 
            // RokWydania
            // 
            this.RokWydania.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RokWydania.DataPropertyName = "Rok Wydania";
            this.RokWydania.HeaderText = "Rok Wydania";
            this.RokWydania.MinimumWidth = 6;
            this.RokWydania.Name = "RokWydania";
            // 
            // Dostepnosc
            // 
            this.Dostepnosc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Dostepnosc.DataPropertyName = "Dostepnosc";
            this.Dostepnosc.HeaderText = "Dostepnosc";
            this.Dostepnosc.MinimumWidth = 6;
            this.Dostepnosc.Name = "Dostepnosc";
            this.Dostepnosc.Width = 109;
            // 
            // Zaznacz
            // 
            this.Zaznacz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Zaznacz.HeaderText = "Zaznacz";
            this.Zaznacz.MinimumWidth = 6;
            this.Zaznacz.Name = "Zaznacz";
            this.Zaznacz.Width = 63;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(937, 540);
            this.Controls.Add(this.dgvKsiazki);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnWypozycz);
            this.Controls.Add(this.btnZwrot);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKsiazki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        private BibliotekaDBDataSet bibliotekaDBDataSet;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource;
        private BibliotekaDBDataSetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter;
        private System.Windows.Forms.DataGridView dgvKsiazki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tytul;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn RokWydania;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dostepnosc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Zaznacz;
    }
}
