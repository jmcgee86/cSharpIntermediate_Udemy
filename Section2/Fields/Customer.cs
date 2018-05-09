using System;
using System.Collections.Generic;
namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();//makes sure Orders is always initialized to empty list

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            //...
        }

    }
}