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
 *      Interfaces
 *          force behavior
 *              icomparable : forces comparison
 *                  strings ==> sort
 *                  must have CompareTo() method which permits 2 inputs and output 1, 0, -1
 *                          if bigger/same/samller (first compared to second)
 *                          
 *          Fully abstract (no code)
 *              all properties/methods : fully public (wihtout being stated)
 *              
 *          you can implement many interfaces
 *              
 *      abstract class
 *          applied as a parent
 *          combination 
 *                          fields int x;
 *                          properties int y {get;set;}
 *                          methods DoThis(){}
 *          either 
 *                          abstgract e.g. methods with no body
 *                          real e.g. methods with body
 *                          
 *      inherit from this class
 *              real : can ignore (inherit)
 *              abstract : empty : must code them out
 *              
 *      code read:
 *              abstract void DoThis(); //parent
 *              override void DoThis(){} //child
 *              
 *      Polymorphism
 *              parent - virtual keyword                    --- publit virtual void DoThis(){}
 *              child - override keyword on method          --- public override/new void DoThis(){}
 *              
 *      
 *      
 */