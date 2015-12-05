using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SimplePointOfSale.Model;

namespace SimplePointOfSale.DAL
{
    public partial class ProductContex : DbContext
    {
        public ProductContex()
            : base("name=ProductStoreConnectionString")
        {
        }
        public DbSet<Product> Product { get; set; }
    }
}
