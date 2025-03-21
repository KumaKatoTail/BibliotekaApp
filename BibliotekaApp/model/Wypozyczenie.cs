using BibliotekaApp.model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BibliotekaApp.model
{
    public class Wypozyczenia
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Ksiazka")]
        public int KsiazkaId { get; set; }
        public Ksiazka Ksiazka { get; set; }

        [ForeignKey("Uzytkownik")]
        public int UzytkownikId { get; set; }
        public Uzytkownik Uzytkownik { get; set; }

        public DateTime DataWypozyczenia { get; set; }
        public DateTime? DataZwrotu { get; set; }
    }
}
