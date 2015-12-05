using SimplePointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Interface
{
    public interface IProductRepository
    {
        Product GetInstance(int productID);
        List<Product> GetAllInstance();
    }
}
