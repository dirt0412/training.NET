using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Rezerwacje
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Id Gościa")]
        public int IdGosc { get; set; }

        [Display(Name = "Prowizja")]
        public decimal Prowizja { get; set; }

        [Display(Name = "Data zameldowania i wymeldowania")]
        public DateTime DataZameldowaniaWymeldowania { get; set; }

        [Required]
        [Display(Name = "Cena")]
        public decimal Cena { get; set; }

        [Required]
        [Display(Name = "Daty utworzenia")]
        public DateTime DatyUtworzenia { get; set; }

        [Required]
        [Display(Name = "Kod Rezerwacji")]
        [StringLength(10, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        public string KodRezerwacji { get; set; }

        //public ICollection<Goscie> Goscie { get; set; }
    }
}