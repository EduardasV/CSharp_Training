using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_16_entity
{
    class Program
    {
        // pull in datbase here; DBContext is our DB object.
        static NorthwindEntities DBContext = new NorthwindEntities();

        static void Main(string[] args)
        {
            var c01 = new Customer();
            c01.likeCoke = true;

            foreach (lab_16_entity.Customer customer in DBContext.Customers)
            {
                //Console.WriteLine("{0} lives in {1}", customer.ContactName, customer.City);
            }


            //var customers =
            //    from c in DBContext.Customers
            //    select c;

            var customers =
                    from c in DBContext.Customers
                    where c.City=="berlin" 
                    select c;


            foreach (Customer c in customers)
            {
               // Console.WriteLine("{0} lives in {1}", c.ContactName, c.City);
            }


            var singleCustomer = DBContext.Customers.First(c => c.Country == "Finland");
            
            Console.WriteLine("{0} lives in {1}", singleCustomer.ContactName, singleCustomer.Country);
            singleCustomer.ContactName += "x";
            Console.WriteLine("{0} lives in {1}", singleCustomer.ContactName, singleCustomer.Country);
            DBContext.SaveChanges();
        }
    }
    partial class Customer
    {
        public bool likeCoke;

    }
}

/*
 *  northwind ==> install via SQL script
 *  project ==> add ==> ado.net entity data model to project
 *      create classes for us e.g. customer class
 *              partial class : manually extend this class to suit
 *  
 *  LINQ Query
 *      var customers = 
 *                      FROM c in DBContext.Customers
 *                      SELECT c
 *              var : type : IQUERYABLE / IENUMERABLE 
 * 
 *  using lambda expressions to help create database queries
 *      var singleCustomer = DBContext.Customers.First(c => c.Country == "Finland");
 *      
 *  update single customer
 *      singleCustomer.ContactName += "fred";
 *      DBContext.SaveChanges();
 *      
 */
