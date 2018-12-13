using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_14_interfaces
{
    class Program
    {
        /*
         * Interfaces
         *  Classes can onl have one parent
         *  class Child : Parent{} //one parent only
         *  if we  want to use other code we can 'implement' other code this this: 
         *     
         *     declare structure : Interface 
         *          interface IDoThis()          C# : Prefix with I : convention
         *              eg IDisposable      manually dispose of object
         *              IEnurmerable        enureate : count : e.g. array
         *              IQueryable          LINQ query : response from database
         *      what does this mean for us?
         *      interface IMustDoThis{          //declare
         *              // one or more fully abstract methods
         *              //all implied public
         *              //all implied abstract
         *              void GottaDoThis();
         *              void AlsoGottaDoThis();
         *      }         
         *      
         *      class MyClass : IMustDoThis{        // class must implement (use)
         *                                          // interface and all it's methods
         *            
         *      }          
         */
        static void Main(string[] args)
        {
            var c = new Child();
            
        }
    }

    //interace to force a certain behaviour
    //interface you MUST override
    //interaces are blank and don't have code in them.
    interface ITools
    {
        int x { get; set; }
        void MustUseThisTool1();
        void MustUseThisTool2();
    }
    class Parent
    {

    }
    class Child : Parent, ITools
    {
        public int x { get; set; }
        public void MustUseThisTool1()
        {
            Console.WriteLine("using tool 1");
        }

        public void MustUseThisTool2()
        {
            Console.WriteLine("using tool 2");
        }
    }
}
/*
 *      SUMMARY:
 *          interfaces are fully abstract (no code whatsoever) - all methods are abstract
 *          Abstract class can have a combination of REAL METHODS and ABSTRACT METHODS 
 *          
 *          Polymorphism : Parent class has 'virtual keyword'
 *                          child class has (optional) override keyword
 *                          
 *                          
 *          
 */