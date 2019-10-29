using System;

namespace BestBuy
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            product.Name = "Nintendo Switch Lite";
            product.Price = 200.00;
           

            Console.WriteLine($"{product.Name} is ${product.Price} and is ${product.PriceWithTax()}");
        }
    }
}