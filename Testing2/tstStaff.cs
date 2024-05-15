using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
        //Good Test Data
        //create some test data to pass the method
        string DateAdded = DateTime.Now.ToShortDateString();
        string StaffAddress = "Ben Russell";
        string StaffName = "Divyansh";
        string StaffPhoneNumber = "07867029044";
        string StaffEmail = "divyanshsingh1800@gmail.com";
        [TestMethod]
        public void InstanceOk()
        {//create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {  //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the proprty
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }
        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
        [TestMethod]
        public void StaffAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Ben Russell";
            //assign the data to the property
            AnStaff.StaffAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffAddress, TestData);
        }
        [TestMethod]
        public void StaffNamePropertyOK()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Divyansh";
            //assign the data to the property
            AnStaff.StaffName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffName, TestData);

        }
        [TestMethod]
        public void StaffPhoneNumberPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "7867029044";
            //assign the data to the property
            AnStaff.StaffPhoneNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffPhoneNumber, TestData);
        }
        [TestMethod]
        public void StaffEmailPropertyOK()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "divyanshsingh1800@gmail.com";
            //assign the data to the property
            AnStaff.StaffEmail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffEmail, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AnStaff.Find(StaffId);
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AnStaff.Find(StaffId);
            //check the staff id
            if (AnStaff.StaffId != 1)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestActiveFound()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke the method 
            Found = AnStaff.Find(StaffId);
            //check active property 
            if (AnStaff.Active != true)
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        { //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke thye method 
            Found = AnStaff.Find(StaffId);
            //check the date property
            if (AnStaff.DateAdded != Convert.ToDateTime("2003-08-28"))
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffAddressFound()
        {//create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke thye method 
            Found = AnStaff.Find(StaffId);
            // check the address property
            if (AnStaff.StaffAddress != "Ben Russell")
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestStaffNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke thye method 
            Found = AnStaff.Find(StaffId);
            // check the name property
            if (AnStaff.StaffName != "Divyansh")
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {//create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke thye method 
            Found = AnStaff.Find(StaffId);
            // check the phone mumber property
            if (AnStaff.StaffPhoneNumber != "07867029044")
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void StaffEmailFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a variable to check the validation
            Boolean Found = false;
            // create a variable to record if data is ok 
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 1;
            //invoke thye method 
            Found = AnStaff.Find(StaffId);
            // check the email property
            if (AnStaff.StaffEmail != "divyanshsingh1800@gmail.com")
            {
                OK = false;
            }
            //test to see that the two values are the same
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void validateMethodOk()
        {
            clsStaff AnStaff = new clsStaff();
            string Error = "";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "a";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffAddressMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "aa";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffAddressMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(74, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void StaffAddressMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(75, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(37, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffAddressMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(76, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffAddressExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffAddress = "";
            StaffAddress = StaffAddress.PadRight(500, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public  void StaffDOBMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffDOBMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffDOBMinPlusOne() {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
           TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBExtremeMax()
        {clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffDOBAddedInvalidData()
        { 
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string DateAdded = "this is not a date";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "a";
            
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "aa";
            
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(44, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffNameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(45, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(46, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(500, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffNameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffName = "";
            StaffName = StaffName.PadRight(22, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNumberMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void StaffPhoneNumberMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "a";

            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffPhoneNumberMinplusOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "aa";

            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNumberMaxLessOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(17,'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNumberMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(18, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffPhoneNumberMaxPlusOne()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(19, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNumberExtremeMax()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(500, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffPhoneNumberMid()
        {

            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffPhoneNumber = "";
            StaffPhoneNumber = StaffPhoneNumber.PadRight(9, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "a";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMinPlusOne() {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "aa";
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(29,'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(30,'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void StaffEmailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(31,'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(15,'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void StaffEmailExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string StaffEmail = "";
            StaffEmail = StaffEmail.PadRight(500, 'a');
            Error = AnStaff.Valid(DateAdded, StaffAddress, StaffName, StaffPhoneNumber, StaffEmail);
            Assert.AreNotEqual(Error, "");
        }


    }
}
       
