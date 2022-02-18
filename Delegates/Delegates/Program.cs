namespace Delegates
{
    using DemoLibrary.Model;
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static ShopingCartModel cart = new ShopingCartModel();

        static void Main(string[] args)
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(SubTotalAlert, CalculateLevelDiscount, AlertUser):C2}");
            Console.WriteLine();

            decimal total = cart.GenerateTotal(
                (subTotal) => Console.WriteLine($"The subtoal for cart2 is {subTotal:C2}"),
                (products, subTotal) =>
                {
                    return subTotal switch
                    {
                        > 100 => subTotal * 0.80M,
                        > 50 => subTotal * 0.85M,
                        > 10 => subTotal * 0.90M,
                        _ => subTotal,
                    };
                },
                (message) => Console.WriteLine($"Cart 2 Alert: {message}")
                );
            Console.WriteLine($"The total for the cart 2 is {total}");
            Console.WriteLine();
            Console.WriteLine("Please press any key to exit the application...");
        }

        private static void SubTotalAlert(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static void AlertUser(string message)
        {
            Console.WriteLine(message);
        }

        private static decimal CalculateLevelDiscount(List<ProductModel> items, decimal subTotal)
        {
            return subTotal switch
            {
                > 100 => subTotal * 0.80M,
                > 50 => subTotal * 0.85M,
                > 10 => subTotal * 0.90M,
                _ => subTotal,
            };
        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}
