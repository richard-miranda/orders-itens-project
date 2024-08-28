using order_itens_project.Entities;
using order_itens_project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace order_itens_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Collecting client data
            Console.WriteLine("Enter Client Data:");
            Console.WriteLine("Name: ");
            String clientName = Console.ReadLine();
            Console.WriteLine("Email: ");
            string clientEmail = Console.ReadLine();
            Console.WriteLine("Birth Date (DD/MM/YYYY): ");
            DateTime clientBirth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, clientBirth);

            //Collecting order data
            Console.WriteLine("Enter order data:");
            Console.WriteLine("Status: ");
            OrderStatus status = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());
            Console.WriteLine("How many items in this order?");
            int orderItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= orderItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                String name = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(name, price);
                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddIem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
