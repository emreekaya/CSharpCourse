using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Add();
            customerMenager.Update();

            ProductMenager productMenager = new ProductMenager();
            productMenager.Add();
            productMenager.Update();

            Customer customer = new Customer();
            customer.ID = 1;
            customer.FirstName = "AAAA";
            customer.LastName = "BBBB";
            customer.City = "CCCC";

            Customer customer2 = new Customer
            {
                ID = 2, FirstName = "XXXXX", LastName = "YYYYY", City = "ZZZZZ"
            };

            Console.WriteLine(customer2.City);
            Console.ReadLine();
        }
    }
}
