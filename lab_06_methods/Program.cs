using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring methods
            void DoThis()
            {
                Console.WriteLine("Doing Nothing");
            }
            // invoking method
            DoThis();
            DoThisAlso();

        }
        //static method : invoke with classname.method()
        static void DoThisAlso()
        {

        }
    }
}
