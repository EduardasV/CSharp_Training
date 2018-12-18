using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notes
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


/*
 *  tuesday review
 * 
 *  entity
 *  northwind
 *  DBContext object
 *  LINQ
 *          from c in customers
 *          where c.city ==  textbox01.text
 *          groupby
 *          orderby
 *          select c
 *            
 *          select new {firstname = c.forename, lastname = c.lastname}
 *          
 *          
 *  foreach(custoemr c in dbcontext.customers) ...
 *  //selecting one record
 *  Lambda to select eg first(c => c.city=="Berlin")
 *     
 *  //Listbox : bind with
 *  Listbox01.ItemsSource.Customer.ToList<Customer>();
 *  Listbox01.displaymemeberpath="city"
 *  //display more than one: XML construct
 *  binding property as well
 *  
 *  CRUD
 *  
 *  Filtering : onkeyup ie filter on each keystroke (bonus)
 *  
 *  OOP
 *  Class : blueprint / template which is used to create (instantiate) real objects
 *          class dog
 *          {
 *              public string name;
 *              public int height;
 *              // constructor method
 *              public dog(string name, int height)
 *              {
 *                  this.name = name;
 *                  this.height = height;
 *              }
 *          }
 *          Dog fido = new dog("fido", 22);
 *          
 *  Methods : functions 
 *          pascalCase and verbs DoThis() Accelerate()
 *          
 *  class : noun, Pascal ie Class dog, Class Engine
 *  
 *  field
 *              private string _interfnalField;
 *  
 *  property
 *              public string external {get; set;}
 *              
 *              get
 *              {
 *                  return this._internalField;
 *              }
 *              // can validate this
 *              set
 *              {
 *                  this._internalField=value;
 *              }
 *              
 *  Events
 *              
 *  Class Parent {}
 *  Class Child : Parent {}
 *  
 *  Sealed class Child {}  // cannot inherit from this child
 *  
 *  Abstract class GrandParent 
 *  {
 *      DoThis(){} //regular method
 *      abstract void DoThat(); //abstract method
 *  }
 *  
 *  class Parent : GrandParent
 *  {
 *      // inherit DoThis()... (ignore here)
 *      public override void DoThat()
 *      {
 *      
 *      }
 *  }
 *  
 *  
 *  Polymorphism
 *  
 *      Parent : Virtual / New
 *      Child : override
 *      
 *  Class MyClass 
 *  {
 *      public static void DoThisNow(){}
 *      public void DoThisAlso(){}
 *      
 *  }
 *      ... Main()
 *      {
 *          //calling static method/props
 *          MyClass.DoThisNow(); //outside of the class
 *          Math.Random();
 *          Math.PI;
 *          // call class method
 *          // instantiate
 *          var instance01 = new MyClass();
 *          instance01.DoThisAlso();
 *      }
 *  
 *  overloading : Same name, but different parameters
 *      DoThis();
 *      DoThis(10);
 *      DoThis(10,20);
 *      DoThis("hi");
 *  
 *  override  : same methid : different code body
 *          Parent : virtual
 *          Child : override
 *  
 *  //if you want to call a parent
 *  .base() from child
 *  
 *  Interface : is public and abstract without specifying it
 *              child : Must override
 *      IComparable 
 *      //can't inherit more than one class but you can inherit from a lot of interfaces
 *      
 *       class Real : IComparable
 *       {
 *           public int CompareTo(object obj)
 *           {
 *               return 1;
 *          }
 *       }
 *  
 *  abstract : class contains 1 or more abstract method
 *              abstract method has NO CODE!!
 *              Child : must overrides method
 *              
 *  
 *  polymorphism
 *  
 *              parent : virtual method
 *              child : optional override / new
 *  
 *  THOUGHTS
 *  
 *  
 *  
 * 
 * 
 * 
 * 
 */
