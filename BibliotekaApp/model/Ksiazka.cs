using System.ComponentModel.DataAnnotations;

namespace BibliotekaApp.model
{
    public class Ksiazka
    {
        [Key]
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public bool Dostepnosc { get; set; } = true;
    }
}
