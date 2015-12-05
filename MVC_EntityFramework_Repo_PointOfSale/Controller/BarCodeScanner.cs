using SimplePointOfSale.Interface;
using SimplePointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Controller
{
    public class BarCodeScanner
    {
        private IProductRepository _productRepository;
        public string ErrorMessage;

        public BarCodeScanner()
        {

        }

        public BarCodeScanner(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public int GetProductID(BarCode barCode)
        {
            int productID = -1;
            if (barCode != null && barCode.ProductID.HasValue)
            {
                productID = barCode.ProductID.Value;
            }
            else
            {
                ErrorMessage = "Invalid bar-code";
            }
            return productID;
        }

        public Product GetProduct(int productID)
        {
            return _productRepository.GetInstance(productID);
        }
    }
}
