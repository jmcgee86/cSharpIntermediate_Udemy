using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercises_Inheritance
{
    public class Stack
    {
        
        public ArrayList list = new ArrayList();

        public void Push (object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("cannot add null to Stack");
            list.Insert(0, obj);
        }

        public object Pop()
        {
            if (list.Count ==0)
                throw new InvalidOperationException("Stack is empty");
            var top = list[0];
            list.Remove(top);
            return top;
        }
        public void Clear()
        {
            if(list.Count<1)
                throw new InvalidOperationException("Stack is empty");
            list.RemoveRange(0, list.Count);
        }
    }
}