using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public class Lecturer : Person
    {


        //attributes for lecturer 
        public string LecturerId { get; set; }
        protected decimal LecturerSalary { get; private set; }


     
        //creating a constructor to instansiate an object of lecturer
        public Lecturer(string lecId, decimal lecSal, string ppsNo, string n, string a, string e, long ph) : base(ppsNo, n, a, e, ph)

        {
            LecturerId = lecId;
            LecturerSalary = lecSal;
            
        }



        //creating method to allow lecturer borrow library property
        public override string BorrowAmount(int numOfRequestedLecturerBorrows)
        {
            string result = numOfRequestedLecturerBorrows + " items borrowed"; 
            return result;

        }



        //create method to facilitate library property return for lecturer 
        public int ReturnItem(int numOfReturns)
        {
            return numOfReturns;
        }




        //create method to allow lecturer request a new item for the library catalogue
        public void RequestItemForCatalogue (string propertyType, string propertyTitle, string dept)
        {

        }




        // overidding base person 
        public override string ToString()
        {
            return "\nLecturerID: " + LecturerId + base.ToString();
        }

    }
}
