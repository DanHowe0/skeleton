using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Testing3
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that os exist
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //the data will be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test
            clsCustomer TestItem = new clsCustomer();
            //set it properties
            TestItem.Has2SV = true;
            TestItem.CustomerNo = 2;
            TestItem.CustFirstName = "Bill";
            TestItem.CustLastName = "Will";
            TestItem.CustEmail = "bill@gmail.com";
            TestItem.CustAddress = "some address";
            TestItem.CustDOB = DateTime.Now;
            //add the item to the property 
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class 
            clsCustomerCollection AlLCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.Has2SV = true;
            TestCustomer.CustomerNo = 2;
            TestCustomer.CustFirstName = "Bill";
            TestCustomer.CustLastName = "Will";
            TestCustomer.CustEmail = "bill@gmail.com";
            TestCustomer.CustAddress = "some address";
            TestCustomer.CustDOB = DateTime.Now;
            //assign the data to the property
            AlLCustomer.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AlLCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create some test data to assign to the property
            //the data will be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an item to the list
            //create the item of the test
            clsCustomer TestItem = new clsCustomer();
            //set it properties
            TestItem.Has2SV = true;
            TestItem.CustomerNo = 2;
            TestItem.CustFirstName = "Bill";
            TestItem.CustLastName = "Will";
            TestItem.CustEmail = "bill@gmail.com";
            TestItem.CustAddress = "some address";
            TestItem.CustDOB = DateTime.Now;
            //add the item to the property 
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomer.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //varibale to store the PK
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Has2SV = true;
            TestItem.CustomerNo = 2;
            TestItem.CustFirstName = "Bill";
            TestItem.CustLastName = "Will";
            TestItem.CustEmail = "bill@gmail.com";
            TestItem.CustAddress = "some address";
            TestItem.CustDOB = DateTime.Now;
            //seet ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomer.Add();
            //set the PK of the test data
            TestItem.CustomerNo = PrimaryKey;
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethod()
        {
            //create an instance of the class
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //variable to store PK
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.Has2SV = true;
            TestItem.CustomerNo = 2;
            TestItem.CustFirstName = "Bill";
            TestItem.CustLastName = "Will";
            TestItem.CustEmail = "bill@gmail.com";
            TestItem.CustAddress = "some address";
            TestItem.CustDOB = DateTime.Now;
            //set   ThisCustomer to the test data
            AllCustomer.ThisCustomer = TestItem;
            //add new record
            PrimaryKey = AllCustomer.Add();
            //se PK of the test data
            TestItem.CustomerNo = PrimaryKey;
            //modify the the test record
            TestItem.Has2SV = false;
            TestItem.CustomerNo = 4;
            TestItem.CustFirstName = "Phill";
            TestItem.CustLastName = "Bricks";
            TestItem.CustEmail = "phill@gmail.com";
            TestItem.CustAddress = "phill address";
            TestItem.CustDOB = DateTime.Now;
            //set the record based on the new test data
            AllCustomer.ThisCustomer = TestItem;
            //update the record
            AllCustomer.Update();
            //find the record
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            //test to see if thiscustomer matches the test data
        }

    }

}

