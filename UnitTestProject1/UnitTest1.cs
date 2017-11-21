using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library_CA;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    { 
        
        [TestMethod]
        public void TestMethod1()
        {
            CollegeData cData = new CollegeData();
            cData.AddStudent("Postgrad", "12356", "78651a", "Orla Orlason", "234 Real Place", "orla@dbs.ie", 123456789);
            string result = cData.FacilitateStudentLoan("12356", -5);
            string expectedResult = "Cannot borrow negative withdrawl number";
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void TestMethod2()
        {
            CollegeData cData = new CollegeData();
            cData.AddStudent("Post grad", "12345", "14789g", "Stephen Cassidy", "123 Real Rd", "stecass@dbs.ie", 0854123017);
            string result = cData.SearchStudents("12345");
            string expected = cData.students[0].ToString();
            Assert.AreEqual(result, expected);
        }



        [TestMethod]
        public void TestMethod3()
        {
            CollegeData cData = new CollegeData();
            string result = cData.SearchLecturers(123);
            string expectedResult = "No match found. Try Again.";
            Assert.AreEqual(expectedResult, result);


        }

        [TestMethod]
        public void TestMethod4()
        {
            CollegeData cData = new CollegeData();
            string result = cData.FacilitateStudentLoan("122143", 6);
            string expectedResult = "Student not on record";
            Assert.AreEqual(expectedResult, result);
        }

        
    

   
    }


}
