using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace lab_04_objects
{
    class Version
    {
        static void Main(string[] args)
        {
            dynamic object02 = new ExpandoObject();
            object02.name = "ed";
            object02.age = 21;
            Console.WriteLine(object02.name);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = "ed";
            Age = 21;
        }
    }
}
