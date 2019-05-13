using System;
using Capitulo9_composition2.Entities;
using Capitulo9_composition2.Entities.Enums;
using System.Globalization;

namespace Capitulo9_composition2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Email: ");
            string Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());

            Client Client = new Client(Name, Email, BirthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Staus: ");
            OrderStatus Status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order Order = new Order(DateTime.Now,Status, Client);

            Console.Write("How many items to ths order: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string PName = Console.ReadLine();
                Console.Write("Product price: ");
                double Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int Quantity = int.Parse(Console.ReadLine());

                Product Product = new Product(PName, Price);
                OrderItem OrderItem = new OrderItem(Quantity, Price, Product);
                Order.AddItem(OrderItem);
            }

            Console.WriteLine();
            Console.WriteLine(Order);
        }
    }
}
