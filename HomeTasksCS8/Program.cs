using System;
using HomeTasksCS8.Exceptions;

namespace HomeTasksCS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
           


            Product product1 = new Product
            {
                No = 2,
                Category = "Drinks",
                Price = 12.5
            };

            Product product2 = new Product
            {
                No = 6,
                Category = "Drinks",
                Price = 20
            };

            Product product3 = new Product
            {
                No = 13,
                Category = "Snacks",
                Price = 3.6
            };

            Product product4 = new Product
            {
                No = 3,
                Category = "Food",
                Price = 7
            };

            //store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(product3);
            store.AddProduct(product4);



            try
            {
                Console.WriteLine(store.GetProductByNo(product1.No));
            }
            catch (ProductNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            







            Console.WriteLine(store.Products.Length);


        }
    }
}
