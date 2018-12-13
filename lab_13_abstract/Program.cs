using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13_abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            c.DoThis();
        }
    }

    public abstract class Parent
    {
        public abstract void DoThis();
    }
    //conrete class which you can instanciate 
    class Child : Parent
    {
        public override void DoThis()
        {

        }
    }
}
