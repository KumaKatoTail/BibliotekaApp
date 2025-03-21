namespace BibliotekaApp
{
    partial class FormZwrot
    {
        /// <summary>
        /// Wymagana zmienna projektowa.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Czyści zasoby używane przez tę formę.
        /// </summary>
        /// <param name="disposing">Jeśli wartość to true, zwolnij zasoby zarządzane; w przeciwnym razie, zwolnij tylko zasoby nienadzorowane.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez projektanta

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvZwrot = new System.Windows.Forms.DataGridView();
            this.btnZwroc = new System.Windows.Forms.Button();
            this.bibliotekaDBDataSet = new BibliotekaApp.BibliotekaDBDataSet();
            this.wypozyczeniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wypozyczeniaTableAdapter = new BibliotekaApp.BibliotekaDBDataSetTableAdapters.WypozyczeniaTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KsiazkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzytkownikIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWypozyczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataZwrotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZwrot
            // 
            this.dgvZwrot.AllowUserToAddRows = false;
            this.dgvZwrot.AllowUserToDeleteRows = false;
            this.dgvZwrot.AllowUserToOrderColumns = true;
            this.dgvZwrot.AutoGenerateColumns = false;
            this.dgvZwrot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZwrot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZwrot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.KsiazkaId,
            this.uzytkownikIdDataGridViewTextBoxColumn,
            this.dataWypozyczeniaDataGridViewTextBoxColumn,
            this.dataZwrotuDataGridViewTextBoxColumn});
            this.dgvZwrot.DataSource = this.wypozyczeniaBindingSource;
            this.dgvZwrot.Location = new System.Drawing.Point(12, 12);
            this.dgvZwrot.Name = "dgvZwrot";
            this.dgvZwrot.ReadOnly = true;
            this.dgvZwrot.RowHeadersVisible = false;
            this.dgvZwrot.RowHeadersWidth = 51;
            this.dgvZwrot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZwrot.Size = new System.Drawing.Size(560, 250);
            this.dgvZwrot.TabIndex = 0;
            // 
            // btnZwroc
            // 
            this.btnZwroc.Location = new System.Drawing.Point(230, 270);
            this.btnZwroc.Name = "btnZwroc";
            this.btnZwroc.Size = new System.Drawing.Size(120, 30);
            this.btnZwroc.TabIndex = 1;
            this.btnZwroc.Text = "Zwróć";
            this.btnZwroc.UseVisualStyleBackColor = true;
            this.btnZwroc.Click += new System.EventHandler(this.btnZwroc_Click);
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
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // KsiazkaId
            // 
            this.KsiazkaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KsiazkaId.DataPropertyName = "KsiazkaId";
            this.KsiazkaId.HeaderText = "KsiazkaId";
            this.KsiazkaId.MinimumWidth = 6;
            this.KsiazkaId.Name = "KsiazkaId";
            this.KsiazkaId.ReadOnly = true;
            this.KsiazkaId.Width = 94;
            // 
            // uzytkownikIdDataGridViewTextBoxColumn
            // 
            this.uzytkownikIdDataGridViewTextBoxColumn.DataPropertyName = "UzytkownikId";
            this.uzytkownikIdDataGridViewTextBoxColumn.HeaderText = "UzytkownikId";
            this.uzytkownikIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uzytkownikIdDataGridViewTextBoxColumn.Name = "uzytkownikIdDataGridViewTextBoxColumn";
            this.uzytkownikIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.uzytkownikIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataWypozyczeniaDataGridViewTextBoxColumn
            // 
            this.dataWypozyczeniaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataWypozyczeniaDataGridViewTextBoxColumn.DataPropertyName = "DataWypozyczenia";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.HeaderText = "DataWypozyczenia";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataWypozyczeniaDataGridViewTextBoxColumn.Name = "dataWypozyczeniaDataGridViewTextBoxColumn";
            this.dataWypozyczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataZwrotuDataGridViewTextBoxColumn
            // 
            this.dataZwrotuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataZwrotuDataGridViewTextBoxColumn.DataPropertyName = "DataZwrotu";
            this.dataZwrotuDataGridViewTextBoxColumn.HeaderText = "DataZwrotu";
            this.dataZwrotuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataZwrotuDataGridViewTextBoxColumn.Name = "dataZwrotuDataGridViewTextBoxColumn";
            this.dataZwrotuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormZwrot
            // 
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.btnZwroc);
            this.Controls.Add(this.dgvZwrot);
            this.Name = "FormZwrot";
            this.Text = "Zwrot książek";
            this.Load += new System.EventHandler(this.FormZwrot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZwrot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wypozyczeniaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZwrot;
        private System.Windows.Forms.Button btnZwroc;
        private BibliotekaDBDataSet bibliotekaDBDataSet;
        private System.Windows.Forms.BindingSource wypozyczeniaBindingSource;
        private BibliotekaDBDataSetTableAdapters.WypozyczeniaTableAdapter wypozyczeniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KsiazkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzytkownikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWypozyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZwrotuDataGridViewTextBoxColumn;
    }
}
