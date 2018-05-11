using System;
using System.Collections;
using System.Collections.Generic;


namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Jim");
            list.Add(DateTime.Today);

            var anotherList = new List <int>();

            anotherList.Add(5);

            var names = new List<string>();
            names.Add("string");

        }
    }
}
