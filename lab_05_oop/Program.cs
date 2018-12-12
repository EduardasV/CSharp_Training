using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.age = 21;
            p.name = "ed";
            Console.WriteLine(p.getCousins());
            p.setCousins(5);
            Console.WriteLine(p.getCousins());
            Child c = new Child();
            c.age = 1;
        }
    }
    class Parent
    {
        //field
        public int age = 0;
        //propert get;set;
        public string name { get; set; }
        private int _numberOfCousins;
        //method
        public int getCousins()
        {
            return this._numberOfCousins;
        }
        public void setCousins(int x)
        {
            if ( x > 0 )
                this._numberOfCousins = x;
        }
        //expanded code property 
        public string employment
        {
            get
            {
                return this.employment;
            }
            set
            {
                this.employment = value;
            }
        }
    }

    class Child :Parent
    {

    }
}
