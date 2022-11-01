using System;

namespace lektion5
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer = new customer();
            customer.ID = -1;
            customer.firstname = "timmy";
            customer.lastname = "safstrom";
            customer.Email = "hej@gotmail.com";
            customer customer1 = new customer();
            customer1.ID = 3;
            customer1.firstname = "carl";
            customer1.lastname = "m";
            customer1.Email = " 4";
            customer customer2 = new customer();
            customer2.ID = 4;
            customer2.firstname = null;
            customer2.lastname = null;
            customer2.Email = null;

            customer.printout(customer);
            customer.printout(customer1);
            customer.printout(customer2);
            
        }
    }
}
