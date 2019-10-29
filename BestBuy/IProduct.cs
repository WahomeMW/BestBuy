namespace BestBuy
{


    interface IProduct
    {
        string Name { get; set; }
        double Price { get; set; }

        double PriceWithTax();

    }
         
}
