using BibliotekaApp.model;
using Microsoft.EntityFrameworkCore;

namespace BibliotekaApp
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Ksiazka> Ksiazki { get; set; }
        public DbSet<Uzytkownik> Uzytkownicy { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\48790\BIBLIOTEKADB.MDF;Integrated Security=True;");
            }
        }
    }
}
