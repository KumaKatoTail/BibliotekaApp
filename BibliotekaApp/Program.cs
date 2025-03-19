using BibliotekaApp.model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BibliotekaApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Rejestracja DbContext
            var services = new ServiceCollection();
            services.AddDbContext<DatabaseContext>(options =>
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\48790\BIBLIOTEKADB.MDF;Integrated Security=True;"));

            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<DatabaseContext>();

            // Tworzymy kontekst aplikacji i uruchamiamy pętlę zdarzeń
            var appContext = new BibliotekaAppContext(dbContext);
            Application.Run(appContext);
        }
    }

    public class BibliotekaAppContext : ApplicationContext
    {
        private readonly DatabaseContext _dbContext;

        public BibliotekaAppContext(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            var loginForm = new LoginForm(_dbContext);
            loginForm.FormClosed += (sender, e) =>
            {
                if (loginForm.DialogResult == DialogResult.OK)
                {
                    ShowMainForm(loginForm.LoggedInUser);
                }
                else
                {
                    ExitThread(); // Zamykamy aplikację, jeśli logowanie się nie powiodło
                }
            };
            loginForm.Show();
        }

        private void ShowMainForm(Uzytkownik loggedInUser)
        {
            var mainForm = new Form1(_dbContext, loggedInUser);
            mainForm.FormClosed += (sender, e) => ExitThread(); // Zamykamy aplikację tylko po zamknięciu Form1
            mainForm.Show();
        }
    }
}
