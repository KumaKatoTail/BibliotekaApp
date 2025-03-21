using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BibliotekaApp.model;

namespace BibliotekaApp
{
    public partial class FormZwrot : Form
    {
        private readonly DatabaseContext _db;
        private readonly int _userId;

        public FormZwrot(DatabaseContext dbContext, int userId)
        {
            InitializeComponent();
            _db = dbContext;
            _userId = userId;
            WyswietlWypozyczoneKsiazki();
        }

        private void WyswietlWypozyczoneKsiazki()
        {
            var wypozyczoneKsiazki = _db.Wypozyczenia
                .Where(w => w.UzytkownikId == _userId && w.DataZwrotu == null)
                .Select(w => new
                {
                    w.Id,
                    w.Ksiazka.Tytul,
                    w.Ksiazka.Autor,
                    w.DataWypozyczenia
                })
                .ToList();

            dgvZwrot.DataSource = wypozyczoneKsiazki;
        }

        private void btnZwroc_Click(object sender, EventArgs e)
        {
            if (dgvZwrot.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz książkę do zwrotu!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int wypozyczenieId = (int)dgvZwrot.SelectedRows[0].Cells["Id"].Value;

            var wypozyczenie = _db.Wypozyczenia.FirstOrDefault(w => w.Id == wypozyczenieId);
            if (wypozyczenie != null)
            {
                wypozyczenie.DataZwrotu = DateTime.Now;
                var ksiazka = _db.Ksiazki.FirstOrDefault(k => k.Id == wypozyczenie.KsiazkaId);
                if (ksiazka != null)
                {
                    ksiazka.Dostepnosc = true;
                }

                _db.SaveChanges();
                MessageBox.Show("Książka została zwrócona!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                WyswietlWypozyczoneKsiazki(); // Odświeżenie listy po zwrocie
            }
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormZwrot_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDBDataSet.Wypozyczenia' table. You can move, or remove it, as needed.
            this.wypozyczeniaTableAdapter.Fill(this.bibliotekaDBDataSet.Wypozyczenia);

        }
    }
}
