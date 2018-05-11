using System;

namespace AccessModifiers
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            // var rating = CalculateRating(excludeOrders: true);
            // if (rating ==0)
            //     System.Console.WriteLine("Promoted to level 1");
            // else
            //     System.Console.WriteLine("Promoted to level 2");
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            

            System.Console.WriteLine("Promote logic changed.");
        }

        // private int CalculateRating(bool excludeOrders)
        // {
        //     return 0;
        // }

    }

    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            
        }
    }
}
