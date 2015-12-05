using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Model
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        [Column("ProductID")]
        [Display(Name = "ProductID")]
        public int ProductID { get; set; }

        [Column("ProductPrice")]
        [Display(Name = "ProductPrice")]
        public decimal ProductPrice { get; set; }

        [Required]
        [MaxLength(60)]
        [Column("ProductName")]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }
    }
}
