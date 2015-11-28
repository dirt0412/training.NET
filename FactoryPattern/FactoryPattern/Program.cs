using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Products.Products.Product1 p1 = new Products.Products.Product1();
            Products.Products.Product2 p2 = new Products.Products.Product2();
            Products.Products.Product3 p3 = new Products.Products.Product3();
            FactoryPattern.Products.Products.CompareProducts compareProducts = new Products.Products.CompareProducts();
            AbstractProduct.AbstractProduct.Item item = compareProducts.ComparePrice(p1,p2,p3);
            Console.WriteLine("Where Name = {0}, Price = {1} ", item.Name, item.Price);

            for (int i = 0; i <= 3; i++)
            {
                AbstractProduct.AbstractProduct.Item position = FactoryPattern.Factory.Factory.GetProductByID(i);
                Console.WriteLine("Where id = {0}, position = {1} ", i, position.Name, position.Price);
                //Console.WriteLine("Where id = {0}, position = {1} ", i, position.Name = "ProductA"+i, position.Price = 7.99M * i);
            }
        }
    }
}
