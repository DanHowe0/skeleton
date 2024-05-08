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
        {
            clsStaff AnStaff = new clsStaff();
            Assert.IsNotNull( AnStaff );
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean TestData = true;
            AnStaff.Active = TestData;
            Assert.AreEqual( AnStaff.Active,TestData);
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
            string TestData = "LE2 7PT";
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




    }

}
