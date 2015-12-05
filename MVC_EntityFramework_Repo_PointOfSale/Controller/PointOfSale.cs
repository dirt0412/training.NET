using SimplePointOfSale.Interface;
using SimplePointOfSale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePointOfSale.Controller
{
    public class PointOfSale
    {
        public IProductRepository ProductRepository;
        public LCDDisplayDevice LCDisplayDevice;
        public Printer Printer;
        public BarCodeScanner BarCodeScanner { get; set; }
        public List<Product> Products { get; set; }

        public PointOfSale(IProductRepository productRepository)
        {
            this.ProductRepository = productRepository;
            LCDisplayDevice = new LCDDisplayDevice();
            Products = new List<Product>();
            Printer = new Printer();
        }

        

        public void GetInput(BarCode barCode = null)
        {
            if (barCode != null)
                GetProduct(barCode);
            else
                GetExitCode();
        }

        public void GetProduct(BarCode barCode)
        {
            BarCodeScanner = new BarCodeScanner(this.ProductRepository);
            var productID = BarCodeScanner.GetProductID(barCode);
            if (productID != -1)
            {
                var product = BarCodeScanner.GetProduct(productID);
                if (product != null)
                {
                    Products.Add(product);
                    var message = string.Format("{0}, {1}", product.ProductName, product.ProductPrice);
                    LCDisplayDevice.MessageToDisplay = message;
                    LCDisplayDevice.PrintMessage(message);
                }
                else
                {
                    LCDisplayDevice.MessageToDisplay = "Product not found";
                    LCDisplayDevice.PrintMessage("Product not found");
                }
            }
            else
            {
                LCDisplayDevice.MessageToDisplay = "Invalid bar-code";
                LCDisplayDevice.PrintMessage("Invalid bar-code");
            }
        }


        public void GetExitCode()
        {
            if (Products.Count > 0)
            {
                var priceSum = 0M;
                foreach (var item in Products)
                {
                    priceSum += item.ProductPrice;
                }
                LCDisplayDevice.MessageToDisplay = priceSum.ToString();
                LCDisplayDevice.PrintMessage(priceSum.ToString());

                PrintReceipt(Products);
            }
        }

        public void PrintReceipt(List<Product> products)
        {
            Printer.PrintReceipt(products);
        }
    }
}
