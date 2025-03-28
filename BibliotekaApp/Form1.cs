﻿using System;
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
            
            var ksiazki = _db.Ksiazki.ToList();
            dgvKsiazki.DataSource = ksiazki;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (_zalogowanyUzytkownik.Rola != "Admin") return;

            using (var formDodaj = new FormDodajKsiazke(_db))
            {
                if (formDodaj.ShowDialog() == DialogResult.OK)
                {
                    WyswietlKsiazki(); // Odśwież listę książek po dodaniu nowej
                }
            }
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
                        _db.Wypozyczenia.Add(new Wypozyczenia
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

        //private void btnZwrot_Click(object sender, EventArgs e)
        //{
        //    var wypozyczenia = _db.Wypozyczenia
        //        .Where(w => w.UzytkownikId == _zalogowanyUzytkownik.Id && w.DataZwrotu == null)
        //        .ToList();

        //    if (!wypozyczenia.Any())
        //    {
        //        MessageBox.Show("Nie masz książek do zwrotu!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }

        //    var wybraneWypozyczenie = wypozyczenia.First();
        //    var ksiazka = _db.Ksiazki.FirstOrDefault(k => k.Id == wybraneWypozyczenie.KsiazkaId);

        //    if (ksiazka != null)
        //    {
        //        ksiazka.Dostepnosc = true;
        //        wybraneWypozyczenie.DataZwrotu = DateTime.Now;
        //        _db.SaveChanges();
        //        WyswietlKsiazki();
        //        MessageBox.Show("Książka zwrócona!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        private void btnZwrot_Click(object sender, EventArgs e)
        {
            using (var formZwrot = new FormZwrot(_db, _zalogowanyUzytkownik.Id))
            {
                if (formZwrot.ShowDialog() == DialogResult.OK)
                {
                    WyswietlKsiazki(); // Odświeżenie listy książek po zwrocie
                }
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