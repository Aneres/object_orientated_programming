using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    public class CollegeData
    {
        // creating a list of lecturers
        List<Lecturer> lecturers = new List<Lecturer>();



        //create empty instance of lecturer
        Lecturer l = null;



        //create method to add lecturer to list
        public string AddLecturer(string lecId, decimal lecSal, string ppsNo, string n, string a, string e, long ph)
        {
            lecturers.Add(l = new Lecturer(lecId, lecSal, ppsNo, n, a, e, ph)); 
            return "Lecturer added to list Lecturers";
        }




        //create a method to search the list of lecturers
        public string SearchLecturers(string lecturerIdEnquiry)
        {
            string result = "Lecturer Id is Not In System";

            foreach (Lecturer lec in lecturers)
            {
                if (lecturerIdEnquiry.Equals(lec.LecturerId))
                {
                    result = lec.ToString();
                }

            }
            return result;
        }




        //overloaded method for searching for lecturer
        public string SearchLecturers(int lecturerIdEnquiry)
        {
            string result = "No match found. Try Again.";

            foreach (Lecturer lec in lecturers)
            {
                if (lecturerIdEnquiry.Equals(lec.Phone))
                {
                    result = lec.ToString();
                }
            }
            return result;
        }




        //method to list all lecturers in list 
        public string getListLecturer()
        {
            string result = null;

            foreach (Lecturer lec in lecturers)
            {
                result += "\n" + lec.Name;
            }
            return result;
        }

    


    //method to facilitate a specific lecturer to borrow books 
    public void FacilitateLecturerLoan(string lecId, int numOfRequestedLecturerBorrows)
    {
        foreach (Lecturer lec in lecturers)
        {
            if (lec.LecturerId.Equals(lecId))
            {
                lec.BorrowAmount(numOfRequestedLecturerBorrows);

            }
        }
    }


        //method to facilitate the return of an item by a specific lecturer
        public int FacilitateLecturerReturn (string lecId, int numOfReturns)
        {
            foreach (Lecturer lec in lecturers)
            {
                if (lec.LecturerId.Equals(lecId))
                {
                    lec.ReturnItem(numOfReturns);
                }
               
            }
            return numOfReturns;
        }





        //create a student list called students
        public List<Student> students = new List<Student>();





        //create instance of student 
        Student s = null;




        //method to add student to the list of students
        public string AddStudent (string stuStatus, string stuId, string ppsNo, string n, string a, string e, long ph)
        {
            students.Add(s = new Student(stuStatus, stuId, ppsNo, n, a, e, ph));
            
                return "Student Added to list Students";
        }





        //method to search list of students
        public string SearchStudents(string studentIdEnquiry)
        {
            string result = "Student Id is Not In System";
            foreach (Student stu in students)
            {
                if (stu.StudentId.Equals(studentIdEnquiry))
                {
                    result = stu.ToString();
                }
                
            }
                return result;
        }




        //method to list all students in list 
        public string getListStudent()
        {
            string result = null;

            foreach (Student stu in students)
            {
                result += "\n" + stu.Name;
            }
            return result;
        }




        //method to link a the loan  to a specific student 
        public string FacilitateStudentLoan(string stuId, int numOfPotentialBorrows)
        {
            string result = "Student not on record";
            foreach (Student stu in students)
            {
                if (stu.StudentId.Equals(stuId))
                {
                    result = stu.BorrowAmount(numOfPotentialBorrows);
                    
                }
            }
            return result;
        }




        //method to facilitate the return of an item to a specific student in students list
        public int FacilitateStudentReturn (string stuId, int numOfReturns)
        {
            foreach(Student stu in students)
            {
                if (s.StudentId.Equals(stuId))
                {
                    s.ReturnItem(numOfReturns);
                }
            }
            return numOfReturns;
        }




        //create a list of books
        List<Book> books = new List<Book>();




        //instance
        Book b = null;

  


        //add to books list
        public string AddBooks (string isbn, string author,  string  propertyTitle)
        {
            books.Add(b = new Book (isbn, author, propertyTitle));
            return "Item added to the book catalogue";
        }
       

        //methos to show books in library catalogue
        public string ShowBooks()
        {
            string result = null;
            foreach (Book b in books)
            {
                result += "\n" + b.ToString();
            }
            return result;
        }
        

        // creating a list of requested items
        List<RequestedCatalogueItems> requestedCatalogueItems = new List<RequestedCatalogueItems>();



        //instance 
         RequestedCatalogueItems req = null;



       //adding requested item to list of requsted items

        public string AddRequestedItem (string propertyType, string propertyTitle, string dept)
        {
           
            requestedCatalogueItems.Add (req = new RequestedCatalogueItems (propertyType, propertyTitle, dept));
            return "Request Added to list";

        }


        //methods to show all requested lecturer items 
        public string ShowRequestItems()
        {
            string result = null;
            foreach (RequestedCatalogueItems req in requestedCatalogueItems)
            {
                result += "\n" + req.ToString();
            }
            return result;
        }


    }

}
