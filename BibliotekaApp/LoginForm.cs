using BibliotekaApp.model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BibliotekaApp
{
    public partial class LoginForm : Form
    {
        private readonly DatabaseContext _db;

        public LoginForm(DatabaseContext dbContext)
        {
            InitializeComponent();
            _db = dbContext;
        }

        public Uzytkownik LoggedInUser { get; private set; }  // Dodajemy właściwość

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text.Trim();
            string haslo = hasloBox.Text.Trim();

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(haslo))
            {
                MessageBox.Show("Wprowadź login i hasło!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sprawdzamy, czy użytkownik istnieje w bazie
            var user = _db.Uzytkownicy.FirstOrDefault(u => u.Login == login && u.Haslo == haslo);

            if (user != null)
            {
                MessageBox.Show($"Zalogowano jako: {user.Rola}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Zapisujemy użytkownika
                LoggedInUser = user;

                // Otwieramy główne okno
                Form1 mainForm = new Form1(_db, user);
                mainForm.Show();
                this.Hide(); // Ukrywamy okno logowania
            }
            else
            {
                MessageBox.Show("Błędny login lub hasło!", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
