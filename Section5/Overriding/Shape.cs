namespace Overriding
{
    public class Cirlce : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a cirlce");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}