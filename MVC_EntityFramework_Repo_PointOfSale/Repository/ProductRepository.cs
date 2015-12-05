using SimplePointOfSale.DAL;
using SimplePointOfSale.Interface;
using SimplePointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductContex entitiesDB = new ProductContex();          

        public Product GetInstance(int productID)
        {
            SimulationDB();            
            return entitiesDB.Product.Where(x => x.ProductID == productID).FirstOrDefault(); 
            //other ways
            //return entitiesDB.Product.Single(e => e.ProductID.Equals(productID));
            //return entitiesDB.Product.Find(productID);
        }

        public List<Product> GetAllInstance()
        {
            SimulationDB();
            return entitiesDB.Product.ToList();
        }

        private void SimulationDB()
        {            
            entitiesDB.Product.Add(new Product() { ProductID = 1, ProductName = "Name1", ProductPrice = 2.2M });
            entitiesDB.Product.Add(new Product() { ProductID = 2, ProductName = "Name2", ProductPrice = 3.5M });
            entitiesDB.Product.Add(new Product() { ProductID = 3, ProductName = "Name3", ProductPrice = 55.8M });            
        }
    }
}
