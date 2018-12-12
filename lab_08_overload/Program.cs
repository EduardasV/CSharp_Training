using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_overload
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance01 = new MyClass();
            instance01.DoThis();
            instance01.DoThis(10);
            instance01.DoThis("hello");
            // don't set default values
            instance01.DoThisAlso();
            // set values
            instance01.DoThisAlso(1);
            instance01.DoThisAlso(1, "string");

            //call method and get 2 outputs
            int output = instance01.DoThisSometimes(out int output2);
            Console.WriteLine(output2);
        }
    }
    class MyClass
    {
        public void DoThis() { }
        public void DoThis(int x) { }
        public void DoThis(string y) { }

        //set default values
        public void DoThisAlso(int x = 5, string y = "hello")
        {
            Console.WriteLine("x is {0} and y is {1}", x , y);
        }

        public int DoThisSometimes(out int y)
        {
            y = 200;
            return 100;
        }
    }    
}
