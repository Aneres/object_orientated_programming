using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
        public abstract class Person
         
    {

        //attributes of person 
        protected string PpsNo { get; private set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }



        //creating a base constructor to instansiate an object of person
        public Person (string ppsNo, string n, string a, string e)
        {
            PpsNo = ppsNo;
            Name = n;
            Address = a;
            Email = e;
        }



        //creating an overloading constructor to instansaiate an object of person
        public Person (string ppsNo, string n, string a, string e, long ph)
        {
            PpsNo = ppsNo;
            Name = n;
            Address = a;
            Email = e;
            Phone = ph;
        }



        //overidding the base constructor
        public override string ToString()
        {
            return "\nPPSN: " + PpsNo + "\nName: " + Name + "\nAddress: " + Address + " \nEmail: " + Email;
        }

        //borrow method to be overridden by subclasses
        public abstract string BorrowAmount(int numOfBorrows);




    }
}
