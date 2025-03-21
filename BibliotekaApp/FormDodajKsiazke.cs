using System;
using System.Windows.Forms;
using BibliotekaApp.model;

namespace BibliotekaApp
{
    public partial class FormDodajKsiazke : Form
    {
        private readonly DatabaseContext _db;

        public FormDodajKsiazke(DatabaseContext dbContext)
        {
            InitializeComponent();
            _db = dbContext;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            string tytul = txtTytul.Text.Trim();
            string autor = txtAutor.Text.Trim();
            if (!int.TryParse(txtRok.Text, out int rok) || string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Wprowadź poprawne dane książki!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _db.Ksiazki.Add(new Ksiazka { Tytul = tytul, Autor = autor, RokWydania = rok, Dostepnosc = true });
            _db.SaveChanges();

            MessageBox.Show("Książka dodana!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
