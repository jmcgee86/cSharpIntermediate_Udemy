using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingDowncasting
{

    class Program
    {
        static void Main(string[] args)
        {
        //Upcasting
            // Text text = new Text();
            // Shape shape = text;

            // text.Width = 200;
            // shape.Width = 100;

            // System.Console.WriteLine(text.Width); // 100 because text and shap are references to same object
        
            // StreamReader reader = new StreamReader(new MemoryStream());
            
            // var list = new ArrayList();
            // list.Add(1);
            // list.Add("Jim");
            // list.Add(new Text());

            // var anotherList = new List<int>();

        //DownCasting
            Shape shape = new Text(); //at runtime object type will be Text
            Text text = (Text) shape;
            

        }
    }
}
