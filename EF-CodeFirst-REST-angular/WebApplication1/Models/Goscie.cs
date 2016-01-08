using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Goscie
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Imię")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        public string Nazwisko { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [StringLength(13, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        public string Telefon { get; set; }

        [Display(Name = "Adres")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 10)]
        public string Adres { get; set; }

        public Rezerwacje Rezerwacje { get; set; }
    } 
}