using SimplePointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Controller
{
    public class Printer
    {
        public string MessageToPrint;
        public void PrintReceipt(List<Product> products)
        {
            if (products.Count > 0)
            {
                var message = string.Empty;
                var totalPrice = 0M;
                foreach (var item in products)
                {
                    message += string.Format("{0}, {1}{2}", item.ProductName, item.ProductPrice, Environment.NewLine);
                    totalPrice += item.ProductPrice;
                }
                MessageToPrint = string.Format("{0}{1}{2}", message, Environment.NewLine, totalPrice);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
