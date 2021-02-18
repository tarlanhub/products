using System;

namespace products
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.ProductName = "Apple Macbook Air";
            product1.ProductPrice = 1500;
            product1.UnitsInStock = 1000;

            Products product2 = new Products();
            product2.ProductName = "Apple Macbook Pro";
            product2.ProductPrice = 2500;
            product2.UnitsInStock = 1000;

            Products[] products = new Products[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName + " "  +   product.ProductPrice +  "$");
            }
        }





       
    }
}
