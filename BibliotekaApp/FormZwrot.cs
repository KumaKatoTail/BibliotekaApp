using System;
using System.Data;
using System.Windows.Forms;

namespace BibliotekaApp
{
    public partial class FormZwrot : Form
    {
        private int userId; 
        private BibliotekaDBDataSet bibliotekaDB;

        public FormZwrot(int userId, BibliotekaDBDataSet bibliotekaDB)
        {
            InitializeComponent();
            this.userId = userId;
            this.bibliotekaDB = bibliotekaDB;
        }

        private void FormZwrot_Load(object sender, EventArgs e)
        {
            this.wypozyczeniaTableAdapter.Fill(this.bibliotekaDBDataSet.Wypozyczenia);
            LoadWypozyczoneKsiazki();
        }

        private void LoadWypozyczoneKsiazki()
        {
            // Pobieranie książek wypożyczonych przez użytkownika
            DataView view = new DataView(bibliotekaDB.Tables["Ksiazki"]);
            view.RowFilter = $"WypozyczajacyId = {userId}"; // Filtrowanie po użytkowniku

            dgvZwrot.DataSource = view; // Przypisanie danych do DataGridView
        }

        private void btnZwroc_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvZwrot.SelectedRows)
            {
                int bookId = Convert.ToInt32(row.Cells["Id"].Value);

                // Znalezienie książki w bazie danych i ustawienie jej jako dostępnej
                DataRow[] rows = bibliotekaDB.Tables["Ksiazki"].Select($"Id = {bookId}");
                if (rows.Length > 0)
                {
                    rows[0]["Dostepnosc"] = "Dostępna";
                    rows[0]["WypozyczajacyId"] = DBNull.Value;
                }
            }

            // Aktualizacja widoku
            LoadWypozyczoneKsiazki();
        }
    }
}
