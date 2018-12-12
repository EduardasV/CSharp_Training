using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_abstractclass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class HolidayPlans
    {
        // ok 
        void DoThis()
        {
            // code here e.g. visit venice
        }
        //incomplete travel plans
        public abstract void Travel();

    }
    class HolidayPlansComplete : HolidayPlans
    {
        public override void Travel()
        {
            // code here travel plans - COMPLETE
        }
    }
}
