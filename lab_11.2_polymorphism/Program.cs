using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11._2_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.HaveAParty();
            Child c = new Child();
            c.HaveAParty();
            Teen t = new Teen();
            t.HaveAParty();
        }
    }

    class Parent
    {
        // parent implementation
        internal virtual void HaveAParty()
        {
            Console.WriteLine("parent is having a dinner party");
        }
    }
    class Child : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Child is having a party");
        }
    }
    class Teen : Parent
    {
        internal override void HaveAParty()
        {
            Console.WriteLine("Teen is having a party");
            base.HaveAParty();
        }
    }
}
