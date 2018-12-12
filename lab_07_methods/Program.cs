using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate new object p
            Parent p = new Parent();
            // static method
            Parent.DoThis();
            // instance
            p.Grow();
            Console.WriteLine(p.age);
        }
    }
    //instance method
    class Parent
    {
        public int age { get; set; }
        public void Grow()
        {
            age++;
        }
        public static void DoThis()
        {

        }
    }
}
