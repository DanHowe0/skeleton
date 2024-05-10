using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomer
    {
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
    }
}
