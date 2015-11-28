using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.AbstractProduct
{
    public abstract class AbstractProduct
    {
        public abstract class Item
        {
            public abstract string Name { get; }
            public abstract decimal Price { get; }            
        }        
        public abstract AbstractProduct.Item ComparePrice(Products.Products.Product1 p1, Products.Products.Product2 p2, Products.Products.Product3 p3);
    }
}
