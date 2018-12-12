using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Parent
    {
        // parent have a party
        public virtual void Party()
        {
            Console.WriteLine("party for the adults");
        }
    }

    class Child1 : Parent
    {
        // child 1 : have a different implementation of have a party method
        public override void Party()
        {
            Console.WriteLine("Child 1 party.");
        }
    }
    class Child2 : Parent
    {
        // child 2 : have a different implementation of have a party method
        public override void Party()
        {
            Console.WriteLine("Child 2 party.");
        }
    }
}
