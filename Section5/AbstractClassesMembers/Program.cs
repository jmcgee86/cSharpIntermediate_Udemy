using System;

namespace AbstractClassesMembers
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shap to clipboard");
        }

        public void Select()
        {
            System.Console.WriteLine("Select the shape");
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectanlge");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {

            var circle = new Circle();
            circle.Draw();

            var rectanlge = new Rectangle();
            rectanlge.Draw();
        }
    }
}
