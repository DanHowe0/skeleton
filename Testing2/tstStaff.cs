using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaff
    {
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
            string TestData = ";
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
            //invoke thye method 
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
            if (AnStaff.StaffPhoneNumber != "7867029044")
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
    }
}
       
