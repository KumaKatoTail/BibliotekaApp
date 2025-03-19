using System.ComponentModel.DataAnnotations;

namespace BibliotekaApp.model
{
    public class Uzytkownik
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public string Rola { get; set; }
    }
}
