namespace BibliotekaApp
{
    partial class FormZwrot
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvZwrot;
        private System.Windows.Forms.Button btnZwroc;
        private System.Windows.Forms.Button btnAnuluj;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZwrot));
            this.dgvZwrot = new System.Windows.Forms.DataGridView();
            this.btnZwroc = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.bibliotekaDBDataSet = new BibliotekaApp.BibliotekaDBDataSet();
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaTableAdapter = new BibliotekaApp.BibliotekaDBDataSetTableAdapters.WypozyczeniaTableAdapter();
            this.bibliotekaDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZwrot
            // 
            this.dgvZwrot.AllowUserToOrderColumns = true;
            this.dgvZwrot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZwrot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZwrot.Location = new System.Drawing.Point(12, 12);
            this.dgvZwrot.Name = "dgvZwrot";
            this.dgvZwrot.RowHeadersVisible = false;
            this.dgvZwrot.RowHeadersWidth = 51;
            this.dgvZwrot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZwrot.Size = new System.Drawing.Size(510, 250);
            this.dgvZwrot.TabIndex = 0;
            // 
            // btnZwroc
            // 
            this.btnZwroc.Location = new System.Drawing.Point(340, 270);
            this.btnZwroc.Name = "btnZwroc";
            this.btnZwroc.Size = new System.Drawing.Size(100, 30);
            this.btnZwroc.TabIndex = 1;
            this.btnZwroc.Text = "Zwróć";
            this.btnZwroc.UseVisualStyleBackColor = true;
            this.btnZwroc.Click += new System.EventHandler(this.btnZwroc_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.Location = new System.Drawing.Point(460, 270);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(100, 30);
            this.btnAnuluj.TabIndex = 2;
            this.btnAnuluj.Text = "Anuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // bibliotekaDBDataSet
            // 
            this.bibliotekaDBDataSet.DataSetName = "BibliotekaDBDataSet";
            this.bibliotekaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wypozyczeniaBindingSource
            // 
            this.wypozyczeniaBindingSource.DataMember = "Wypozyczenia";
            this.wypozyczeniaBindingSource.DataSource = this.bibliotekaDBDataSet;
            // 
            // wypozyczeniaTableAdapter
            // 
            this.wypozyczeniaTableAdapter.ClearBeforeFill = true;
            // 
            // bibliotekaDBDataSetBindingSource
            // 
            this.bibliotekaDBDataSetBindingSource.DataSource = this.bibliotekaDBDataSet;
            this.bibliotekaDBDataSetBindingSource.Position = 0;
            // 
            // FormZwrot
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnZwroc);
            this.Controls.Add(this.dgvZwrot);
            this.Name = "FormZwrot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zwrot książek";
            this.Load += new System.EventHandler(this.FormZwrot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private BibliotekaDBDataSet bibliotekaDBDataSet;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private BibliotekaDBDataSetTableAdapters.WypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private System.Windows.Forms.BindingSource bibliotekaDBDataSetBindingSource;
    }
}
