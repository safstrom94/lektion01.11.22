using System;
using System.Collections.Generic;
using System.Text;

namespace lektion5
{
    public class customer
    {
        private int id;
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value < 0)
                {
                    id = 0;
                }
                else
                {
                    id = value;
                }
            }
        }
        private string FirstName;
        public string firstname
        {
            get
            {
                return FirstName;
            }
            set
            {
                if (value == null)
                {
                    FirstName = "no First name";
                }
                else
                {
                    FirstName = value;
                }
            }
        }
        private string LastName;
        public string lastname
        {
            get
            {
                return LastName;
            }
            set
            {
                if (value == null)
                {
                    LastName = "No Last Name";
                }
                else
                {
                    LastName = value;
                }
            }
        }
        
        
        private string EMail;
        public string Email
        {
            get
            {
                return EMail;
            }
            set
            {
                if (value == null)
                {
                    EMail = "Email is empty";
                }
                else
                {
                    EMail = value;
                }
            }
        }
    public void printout(customer c1)
        {
            Console.WriteLine(c1.id +" "+ c1.FirstName +" " + c1.LastName + " "+ c1.EMail);
        }
    }
}