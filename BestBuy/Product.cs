using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuy
{
    class Product : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public double PriceWithTax()
        {
            return Price * 1.1;

        }
    }
}
