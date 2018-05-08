using System;

namespace Methods
{


    class Program
    {
        static void Main(string[] args)
        {
            // var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
            if (result)
                System.Console.WriteLine(number);
            else
            {
                System.Console.WriteLine("conversion failed");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1,2));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10,20);
                //point.Move(new Point(40,60));
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100,200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); 
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("An unexpecter error occured");
            }
        }
    }
}
