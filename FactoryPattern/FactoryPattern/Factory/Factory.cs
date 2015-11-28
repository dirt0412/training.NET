using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Products;
using FactoryPattern.AbstractProduct;

namespace FactoryPattern.Factory
{
    public static class Factory 
    {
        public static AbstractProduct.AbstractProduct.Item GetProductByID(int id) 
        {
            switch (id)
            {
                case 0:
                    return new Products.Products.Product2();
                case 1:
                    return new Products.Products.Product1();
                case 2:
                case 3:
                    return new Products.Products.Product3();
                default:
                    return new Products.Products.Product3();
            }
        }
    }
}
