using System;

namespace Constructors
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1,"John");

            var order = new Order();
            customer.Orders.Add(order);

            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);
        }
    }
}
