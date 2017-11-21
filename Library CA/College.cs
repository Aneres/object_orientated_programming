using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_CA
{
    class College
    {

        static void Main(string[] args)
        {

            //variables
            int guestSelection = 0, studentMenuSelection, lecturerMenuSelection;



            //instance for switch statement
            CollegeData cData = new CollegeData();




            //entering dummy data to test functionality

            //add student
            Console.WriteLine(cData.AddStudent("Post grad", "12345", "14789g", "Stephen Cassidy", "123 Real Rd", "stecass@dbs.ie", 0854123017));
            Console.WriteLine(cData.AddStudent("Postgrad", "12356", "78651a", "Orla Orlason", "234 Real Place", "orla@dbs.ie", 123456789));
            Console.WriteLine(cData.AddStudent("Postgrad", "34567", "90876d", "Frank Kelsey", "148 Happy St", "fran@dbs.ie", 098652131));
            Console.WriteLine(cData.AddStudent("undergrad", "12310", "25870m", "Lilly Scully", "10 Ten Place", "lscully@dbs.ie", 1290853422));
            Console.WriteLine(cData.AddStudent("Under Grad", "55542", "3698p", "Dillon Day", "45 Apartments", "day@dbs.ie", 256910031));

            //add lecturer
            Console.WriteLine(cData.AddLecturer("12457", 50000, "03214l", "Kevin Mance", "124 Park Place", "km@dbs.ie", 325784369));
            Console.WriteLine(cData.AddLecturer("36784", 45000, "47530w", "Mary James", "11 Willim Hill", "mj@dbs.ie", 987514141));
            Console.WriteLine(cData.AddLecturer("36944", 100000, "87560r", "Julia Leer", "1 Grafton street", "jl@dbs.ie", 360457891));
            Console.WriteLine(cData.AddLecturer("70084", 25000, "23478k", "David Giles", "311 Park street", "dj@dbs.ie", 36176001));
            Console.WriteLine(cData.AddLecturer("34100", 47000, "65985q", "Camilla Vernon", "22 House Avenue", "cv@dbs.ie", 25554711));

            //add requested item
            Console.WriteLine(cData.AddRequestedItem("book", "Learn To Code", "IT"));
            Console.WriteLine(cData.AddRequestedItem("book", "Tectonic Plates", "Geography"));
            Console.WriteLine(cData.AddRequestedItem("cd", "Learning Thai", "International Langauges"));
            Console.WriteLine(cData.AddRequestedItem("book", "The Philosophy Of The Mind", "Philosophy"));
            Console.WriteLine(cData.AddRequestedItem("Dvd", "Witness", "English"));

            //add items to books
            Console.WriteLine(cData.AddBooks("12456", "Book 1 Title", "Book"));
            Console.WriteLine(cData.AddBooks("16234", "Book 2 Title", "Book"));
            Console.WriteLine(cData.AddBooks("23667", "Book 3 Title", "Book"));
            Console.WriteLine(cData.AddBooks("66701", "Book 4 Title", "Book"));
            Console.WriteLine(cData.AddBooks("71368", "Book 5 Title", "Book"));



            //menu loop
            int userSelection = 1;

            do
            {
                //Intro menu for the DBS library program.
                Console.WriteLine("\nWelcome to the Dublin Business School Library\nPress 1 to enter the Menu\nPress 2 to quit");
                int.TryParse(Console.ReadLine(), out userSelection);

                if (userSelection == 1)
                {
                    Console.WriteLine("Press 1 to enter the student stream\nPress 2 to enter the lecturer stream\nPress 3 to display library catalogues");
                    int.TryParse(Console.ReadLine(), out guestSelection);
                  

                }
               
                if (guestSelection == 1)
                {
                    Console.WriteLine("Press 1 to add student\nPress 2 to inititate loan process\nPress 3 to facilitate item return\nPress 4 for student enquiry\nPress 5 to list the names of students");
                    int.TryParse(Console.ReadLine(), out studentMenuSelection);
                    



                    switch (studentMenuSelection)
                    {
                        case 1:  // reading info to add a student to the students list
                            {
                                //variable
                                long ph;
                               
                                Console.WriteLine("Enter Student Id:");            
                                string stuId = Console.ReadLine();
                                Console.WriteLine("Enter Student Status:");
                                string stuStatus = Console.ReadLine();
                                stuStatus.ToLower();
                                Console.WriteLine("Enter Student PPS Number:");    
                                string ppsNo = Console.ReadLine();
                                Console.WriteLine("Enter Student Name:");          
                                string n = Console.ReadLine();
                                n.ToLower();
                                Console.WriteLine("Enter Student Address:");       
                                string a = Console.ReadLine();
                                a.ToLower();
                                Console.WriteLine("Enter Student Email:");         
                                string e = Console.ReadLine();
                                Console.WriteLine("Enter Student Phone Number:"); 
                                long.TryParse(Console.ReadLine(), out ph);



                                // adding a student to the list
                                Console.WriteLine(cData.AddStudent(stuStatus, stuId, ppsNo, n, a, e, ph));

                                break;
                            }



                        case 2: // facilitating an item loan for a student
                            {
                                Console.WriteLine("Enter Student Id: ");
                                string stuId = Console.ReadLine();
                                Console.WriteLine("Enter number of items to be borrowed: ");
                                int numOfPotentialBorrows = int.Parse(Console.ReadLine());


                                //call borrow method on an instance of student
                                Console.WriteLine(cData.FacilitateStudentLoan(stuId, numOfPotentialBorrows));

                                break;
                            }



                        case 3: //facilitating item return for a student
                            {

                                Console.WriteLine("Enter Student Id: ");
                                string stuId = Console.ReadLine();
                                Console.WriteLine("Enter number of items to be returned: ");
                                int numOfReturns = int.Parse(Console.ReadLine());



                                //calling student return method on  instance of student
                                Console.WriteLine(cData.FacilitateStudentReturn(stuId, numOfReturns) + " Item(s) Returned ");
                                break;
                            }




                        case 4: // Performing an enquiry on a student
                            {
                                Console.WriteLine("Enter the student Id: ");
                                string studentIdEnquiry = Console.ReadLine();

                                //calling method to search the student list for specific student number
                                Console.WriteLine("Enquiry Results: " + cData.SearchStudents(studentIdEnquiry));
                                break;
                            }




                        case 5: //get list of student names
                           
                            {
                                Console.WriteLine("Student Names: \n" + cData.getListStudent());

                                break;

                            }


                        default:
                            {
                                Console.WriteLine("Error. Request Unknown. Please try again.");
                                break;
                            }

                    }


                }

                else if (guestSelection == 2)  // switch statement displaying the program options for a lecturer
                {
                    Console.WriteLine("Press 1 to add lecturer\nPress 2 to inititate loan process\nPress 3 to facilitate item return\nPress 4 for lecturer enquiry\nPress 5 to make a request to add new media to the library catalogue\nPress 6 to list names of Lecturers");
                    lecturerMenuSelection = int.Parse(Console.ReadLine());


                    switch (lecturerMenuSelection)
                    {
                        case 1: //reading user input to create a lecturer for the lecturer list
                            {
                                // variable 
                                long ph;

                                Console.WriteLine("Enter Lecturer Id:");            
                                string lecId = Console.ReadLine();
                                Console.WriteLine("Enter Lecturer Salary: ");
                                decimal lecSalary = decimal.Parse(Console.ReadLine());  
                                Console.WriteLine("Enter Lecturer PPS Number:");    
                                string ppsNo = Console.ReadLine();
                                Console.WriteLine("Enter Lecturer Name:");         
                                string n = Console.ReadLine();
                                n.ToLower();
                                Console.WriteLine("Enter Lecturer Address:");       
                                string a = Console.ReadLine();
                                a.ToLower();
                                Console.WriteLine("Enter Lecturer Email:");         
                                string e = Console.ReadLine();
                                Console.WriteLine("Enter Lecturer Phone Number:");
                                long.TryParse(Console.ReadLine(), out ph);




                                // adding a lecturer to the list
                                Console.WriteLine(cData.AddLecturer(lecId, lecSalary, ppsNo, n, a, e, ph));

                                break;
                            }




                        case 2: // facilitating an item loan for lecturer
                            {

                                Console.WriteLine("Enter Lecturer Id: ");
                                string lecId = Console.ReadLine();
                                Console.WriteLine("Enter number of items to be borrowed: ");
                                int numOfRequestedLecturerBorrows = int.Parse(Console.ReadLine());



                                //calling borrow method for specific instance of lecturer
                                cData.FacilitateLecturerLoan(lecId, numOfRequestedLecturerBorrows);
                                Console.WriteLine("{0} items on loan from system", numOfRequestedLecturerBorrows);

                                break;
                            }




                        case 3:  //facilitating an item return for an instance of lecturer
                            {
                                Console.WriteLine("Enter Lecturer Id: ");
                                string lecId = Console.ReadLine();
                                Console.WriteLine("Enter how many items to be returned: ");
                                int numOfReturns = int.Parse(Console.ReadLine());




                                //calling the lecturer return method on specific lecturer
                                Console.WriteLine(cData.FacilitateLecturerReturn(lecId, numOfReturns) + " Items Returned ");

                                break;
                            }



                        case 4: // Performing an enquiry on lecturers
                            {
                                Console.WriteLine("Enter the Lecturer Id: ");
                                string lecturerIdEnquiry = Console.ReadLine();




                                //search lecturer list
                                cData.SearchLecturers(lecturerIdEnquiry);

                                Console.WriteLine(cData.SearchLecturers(lecturerIdEnquiry));

                                break;
                            }




                        case 5: // Facilitating a request to add new items to the library catalogue
                            {
                                Console.WriteLine("Enter a Lecturer Id: ");
                                string lecId = Console.ReadLine();
                                Console.WriteLine("Enter the Property Type of the Requested Item: ");
                                string propertyType = Console.ReadLine();
                                propertyType.ToLower();
                                Console.WriteLine("Enter the title of the item: ");
                                string propertyTitle = Console.ReadLine();
                                propertyTitle.ToLower();
                                Console.WriteLine("Enter the department requesting the item: ");
                                string dept = Console.ReadLine();




                                // add requested item to list 
                                Console.WriteLine("Request Added: " + cData.AddRequestedItem(propertyType, propertyTitle, dept));

                                break;
                            }



                        case 6: // display list of lecturers
                            {
                                Console.WriteLine("List of Lecturers" + (cData.getListLecturer()));

                                break;

                            }



                        default:
                            {
                                Console.WriteLine("Error. Request Unknown. Please try again.");
                                break;
                            }

                    }
                    

                }
                else if(guestSelection == 3)
                {
                    Console.WriteLine("Books Catalogue :\n" + cData.ShowBooks());
                    Console.WriteLine("Requested Items Catalogue: " + cData.ShowRequestItems());

                }
            } while (userSelection == 1);


                    Console.ReadLine();
        }

    }
}

