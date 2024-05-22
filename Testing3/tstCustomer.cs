using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
        //good test data 
        string CustFirstName = "Bill";
        string CustLastName = "Will";
        string CustDOB = DateTime.Now.AddYears(-15).ToShortDateString();
        string CustEmail = "bill@gmail.com";
        string CustAddress = "some address";

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void Has2SVPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Has2SV = TestData;
            Assert.AreEqual(AnCustomer.Has2SV, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 5;
            AnCustomer.CustomerNo = TestData;
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void CustFirstNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Kiaran";
            AnCustomer.CustFirstName = TestData;
            Assert.AreEqual(AnCustomer.CustFirstName, TestData);
        }

        [TestMethod]
        public void CustLastNamePropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "Cotterill";
            AnCustomer.CustLastName = TestData;
            Assert.AreEqual(AnCustomer.CustLastName, TestData);
        }

        [TestMethod]
        public void CustDOBPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            AnCustomer.CustDOB = TestData;
            Assert.AreEqual(AnCustomer.CustDOB, TestData);
        }

        [TestMethod]
        public void CustEmailPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "kiarancot@gmail.com";
            AnCustomer.CustEmail = TestData;
            Assert.AreEqual(AnCustomer.CustEmail, TestData);
        }

        [TestMethod]
        public void CustAddressPropertyOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = "68, assarts road";
            AnCustomer.CustAddress = TestData;
            Assert.AreEqual(AnCustomer.CustAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create some test data
            Int32 CustomerNo = 1;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //test to see if the results is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the customer no 
            if (AnCustomer.CustomerNo != 2)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestHas2SVFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the 2 step verfication
            if (AnCustomer.Has2SV != true)
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustFirstNameFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the first name
            if (AnCustomer.CustFirstName != "Bill")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustLastNameFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the Last name
            if (AnCustomer.CustLastName != "Will")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustDOBFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the DOB
            if (AnCustomer.CustDOB != Convert.ToDateTime("12/02/2000"))
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustEmailFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the email
            if (AnCustomer.CustEmail != "bill@gmail.com")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustAddressFound()
        {
            //creates an istance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean veriable to store the results of the validation
            Boolean Found = false;
            //create a boolean varaible to record if the data is ok
            Boolean OK = true;
            //create some test data
            Int32 CustomerNo = 2;
            //invoke method
            Found = AnCustomer.Find(CustomerNo);
            //check the address
            if (AnCustomer.CustAddress != "some address")
            {
                OK = false;
            }
            //test to see if the results is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = "a"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = "aa"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            CustFirstName = CustFirstName.PadRight(14, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            CustFirstName = CustFirstName.PadRight(15, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            CustFirstName = CustFirstName.PadRight(7, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            CustFirstName = CustFirstName.PadRight(16, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustFirstNameExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustFirstName = ""; //should trigger error
            CustFirstName = CustFirstName.PadRight(500, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustLastNameMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = "a"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = "aa"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            CustLastName = CustLastName.PadRight(14, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            CustLastName = CustLastName.PadRight(15, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            CustLastName = CustLastName.PadRight(7, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            CustLastName = CustLastName.PadRight(16, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustLastNameExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustLastName = ""; //should trigger error
            CustLastName = CustLastName.PadRight(500, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = "a"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = "aa"; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should trigger error
            CustEmail = CustEmail.PadRight(19, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should pass
            CustEmail = CustEmail.PadRight(20, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should pass
            CustEmail = CustEmail.PadRight(10, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should trigger error
            CustEmail = CustEmail.PadRight(21, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustEmailExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustEmail = ""; //should trigger error
            CustEmail = CustEmail.PadRight(500, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should trigger error
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = "a"; //should pass
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = "aa"; //should pass
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMaxLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should pass
            CustAddress = CustAddress.PadRight(19, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should pass
            CustAddress = CustAddress.PadRight(20, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMid()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should pass
            CustAddress = CustAddress.PadRight(10, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should trigger error
            CustAddress = CustAddress.PadRight(21, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustAddressExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //test data to pass
            string CustAddress = ""; //should trigger error
            CustAddress = CustAddress.PadRight(500, 'a');
            //invoke method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 200 years ago
            TestDate = TestDate.AddYears(-200);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 123 years ago
            TestDate = TestDate.AddYears(-123);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 124 years ago
            TestDate = TestDate.AddYears(-124);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the year was 125 years ago
            TestDate = TestDate.AddYears(-125);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxMinusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is 14 years ago
            TestDate = TestDate.AddYears(-14);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the year was 15 years ago 
            TestDate = TestDate.AddYears(-15);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        public void DOBMaxPlusOne()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the year was 16 years ago 
            TestDate = TestDate.AddYears(-16);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //create a varible to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in 1000 years
            TestDate = TestDate.AddYears(1000);
            //convert the date variable to a string variable
            string CustDOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBAddedInvalidData()
        {
            //create an instance of the class we want
            clsCustomer AnCustomer = new clsCustomer();
            //string varaible to store any error message
            string Error = "";
            //set the DOB to a non date value
            string CustDOB = "this is not a date";
            //invoke the method
            Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
