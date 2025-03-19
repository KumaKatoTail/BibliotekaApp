using System;
using System.Linq;
using System.Windows.Forms;
using BibliotekaApp.model;

namespace BibliotekaApp
{
    public partial class Form1 : Form
    {
        private readonly DatabaseContext _db;
        private readonly Uzytkownik _zalogowanyUzytkownik;

        public Form1(DatabaseContext dbContext, Uzytkownik user)
        {
            InitializeComponent();
            _db = dbContext;
            _zalogowanyUzytkownik = user;

            lblWitaj.Text = $"Witaj, {_zalogowanyUzytkownik.Login}!";
            UstawWidokDlaRoli();
            WyswietlKsiazki();
        }

        private void UstawWidokDlaRoli()
        {
            bool isAdmin = _zalogowanyUzytkownik.Rola == "Admin";

            btnDodaj.Visible = isAdmin;
            btnUsun.Visible = isAdmin;
            btnWypozycz.Visible = !isAdmin;
            btnZwrot.Visible = !isAdmin;
        }

        private void WyswietlKsiazki()
        {
            // Sprawdzenie, czy kolumny są już dodane
            if (dgvKsiazki.Columns.Count == 0)
            {
                // Dodanie kolumny "Zaznacz"
                DataGridViewCheckBoxColumn zaznaczColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Zaznacz",
                    HeaderText = "Zaznacz",
                    Width = 60
                };
                dgvKsiazki.Columns.Insert(0, zaznaczColumn);

                // Dodanie pozostałych kolumn
                DodajKolumne("Id", "Id", false);
                DodajKolumne("Tytul", "Tytul");
                DodajKolumne("Autor", "Autor");
                DodajKolumne("RokWydania", "Rok Wydania");
                DodajKolumne("Dostepnosc", "Dostępność");
            }

            // Pobranie książek z bazy danych
            var ksiazki = _db.Ksiazki.ToList();
            dgvKsiazki.DataSource = ksiazki;
        }

        private void DodajKolumne(string nazwa, string naglowek, bool jestCheckbox = false)
        {
            if (!dgvKsiazki.Columns.Contains(nazwa))
            {
                if (jestCheckbox)
                {
                    dgvKsiazki.Columns.Add(new DataGridViewCheckBoxColumn
                    {
                        Name = nazwa,
                        HeaderText = naglowek,
                        DataPropertyName = nazwa
                    });
                }
                else
                {
                    dgvKsiazki.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = nazwa,
                        HeaderText = naglowek,
                        DataPropertyName = nazwa
                    });
                }
            }
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (_zalogowanyUzytkownik.Rola != "Admin") return;

            string tytul = txtTytul.Text.Trim();
            string autor = txtAutor.Text.Trim();
            if (!int.TryParse(txtRok.Text, out int rok) || string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Wprowadź poprawne dane książki!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _db.Ksiazki.Add(new Ksiazka { Tytul = tytul, Autor = autor, RokWydania = rok, Dostepnosc = true });
            _db.SaveChanges();
            WyswietlKsiazki();
            MessageBox.Show("Dodano książkę!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            if (_zalogowanyUzytkownik.Rola != "Admin") return;

            try
            {
                // Pobranie książek, które zostały zaznaczone
                var zaznaczoneKsiążki = dgvKsiazki.Rows.Cast<DataGridViewRow>()
                    .Where(row => Convert.ToBoolean(row.Cells["Zaznacz"].Value))  // Jeżeli checkbox jest zaznaczony
                    .Select(row => (int)row.Cells["Id"].Value)
                    .ToList();

                // Sprawdzamy, czy są zaznaczone książki do usunięcia
                if (zaznaczoneKsiążki.Any())
                {
                    foreach (var id in zaznaczoneKsiążki)
                    {
                        var ksiazka = _db.Ksiazki.FirstOrDefault(k => k.Id == id);
                        if (ksiazka != null)
                        {
                            _db.Ksiazki.Remove(ksiazka);
                        }
                    }
                    _db.SaveChanges();
                    WyswietlKsiazki();
                    MessageBox.Show("Usunięto zaznaczone książki!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wybierz książki do usunięcia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void btnWypozycz_Click(object sender, EventArgs e)
        {
            var zaznaczoneKsiazki = dgvKsiazki.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["Zaznacz"].Value))
                .ToList();

            if (zaznaczoneKsiazki.Count > 0)
            {
                foreach (var row in zaznaczoneKsiazki)
                {
                    int idKsiazki = (int)row.Cells["Id"].Value;
                    var ksiazka = _db.Ksiazki.FirstOrDefault(k => k.Id == idKsiazki);

                    if (ksiazka != null && ksiazka.Dostepnosc)
                    {
                        ksiazka.Dostepnosc = false;
                        _db.Wypozyczenia.Add(new Wypozyczenie
                        {
                            KsiazkaId = ksiazka.Id,
                            UzytkownikId = _zalogowanyUzytkownik.Id,
                            DataWypozyczenia = DateTime.Now
                        });

                        _db.SaveChanges();
                        WyswietlKsiazki();
                        MessageBox.Show($"Książka '{ksiazka.Tytul}' wypożyczona!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Niektóre książki są już wypożyczone!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Zaznacz książki do wypożyczenia!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnZwrot_Click(object sender, EventArgs e)
        {
            var wypozyczenia = _db.Wypozyczenia
                .Where(w => w.UzytkownikId == _zalogowanyUzytkownik.Id && w.DataZwrotu == null)
                .ToList();

            if (!wypozyczenia.Any())
            {
                MessageBox.Show("Nie masz książek do zwrotu!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var wybraneWypozyczenie = wypozyczenia.First();
            var ksiazka = _db.Ksiazki.FirstOrDefault(k => k.Id == wybraneWypozyczenie.KsiazkaId);

            if (ksiazka != null)
            {
                ksiazka.Dostepnosc = true;
                wybraneWypozyczenie.DataZwrotu = DateTime.Now;
                _db.SaveChanges();
                WyswietlKsiazki();
                MessageBox.Show("Książka zwrócona!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSzukaj_TextChanged(object sender, EventArgs e)
        {
            string fraza = txtSzukaj.Text.ToLower();
            dgvKsiazki.DataSource = _db.Ksiazki
                .Where(k => k.Tytul.ToLower().Contains(fraza) ||
                            k.Autor.ToLower().Contains(fraza) ||
                            k.RokWydania.ToString().Contains(fraza))
                .ToList();
        }
    }
}
