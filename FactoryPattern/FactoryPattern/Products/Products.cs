using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Products
{
    public class Products
    {
        public class Product1 : AbstractProduct.AbstractProduct.Item
        {
            public override string Name
            {
                get
                {
                    return "Product1";
                }
            }
            public override decimal Price
            {
                get
                {
                    return 2.3M;
                }
            }
        }

        public class Product2 : AbstractProduct.AbstractProduct.Item
        {
            public override string Name
            {
                get
                {
                    return "Product2";
                }
            }
            public override decimal Price
            {
                get
                {
                    return 33.80M;
                }
            }
        }

        public class Product3 : AbstractProduct.AbstractProduct.Item
        {
            public override string Name
            {
                get
                {
                    return "Product3";
                }
            }
            public override decimal Price
            {
                get
                {
                    return 2300.50M;
                }
            }
        }

        public class CompareProducts : AbstractProduct.AbstractProduct
        {
            public override AbstractProduct.AbstractProduct.Item ComparePrice(Products.Product1 p1, Products.Product2 p2, Products.Product3 p3)
            {
                if (p1.Price <= p2.Price)
                {
                    if (p3.Price <= p2.Price)
                        return new Products.Product2();
                    else
                        return new Products.Product3();
                }
                else
                if (p1.Price <= p3.Price)
                    return new Products.Product3();
                else
                    return new Products.Product1();
            }

        }
    }
}
