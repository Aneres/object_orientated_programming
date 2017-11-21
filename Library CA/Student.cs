using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public class Student : Person
    {
    

        // attributes of a student
        public string StudentStatus { get; set; }
        public string StudentId { get; set; }
        public int StuItemLoanLimit { get;  protected set; } 




        //creating a student constructor 
        public Student(string stuStatus, string stuId, string ppsNo, string n, string a, string e, long ph) : base (ppsNo,  n,  a,  e,  ph)

        { 
            StudentStatus = stuStatus;
            StudentId = stuId;
            StatusLoanLimit();
        }



        //creating a method for setting a student limit to borrow library property/
   
            public void StatusLoanLimit ()
            {
            



                string status= StudentStatus.ToLower();
            if (status.Equals("underGrad") || status.Equals("undergraduate") || status.Equals("under grad") || status.Equals("under graduate"))
            {
                StuItemLoanLimit = 5;

            }
            else if (status.Equals("postGrad") || status.Equals("postgraduate") || status.Equals("post grad") || status.Equals("post graduate"))
            {
                StuItemLoanLimit = 10;
            }

        }



        //create a borrow method for student, overidding abstract person one

        public override string BorrowAmount(int numOfPotentialBorrows)
        {
            string result = "Cannot borrow negative withdrawl number";
            if (numOfPotentialBorrows > 0)
            {
                if (StuItemLoanLimit > numOfPotentialBorrows)
                {
                    StuItemLoanLimit -= numOfPotentialBorrows;
                    result = numOfPotentialBorrows + " items borrowed";
                }
                else
                {
                    result = "Student exceeded loan limit. Request Denied.";
                }
            }
            return result;

        }



        //create method to facilitate an item return for student

        public int ReturnItem (int numOfReturns)
        {
        
            StuItemLoanLimit += numOfReturns;

            return StuItemLoanLimit;

        }

        //overridding base person
        public override string ToString()
        {
           return  "\nStudent Status: " + StudentStatus + "\nStudent Id:" + StudentId  + base.ToString();
        }



    }
         

   

        


}
