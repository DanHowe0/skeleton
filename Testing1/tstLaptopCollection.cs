using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Testing1
{
    [TestClass]
    public class tstLaptopsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //test to see if it exists
            Assert.IsNotNull(AllLaptops);
        }
        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create some test data to assign
            List<clsLaptops> TestList = new List<clsLaptops>();
            //add an item to the list
            clsLaptops TestItem = new clsLaptops();
            //set the properties
            TestItem.LaptopID = 1;
            TestItem.LaptopModel = "Slim";
            TestItem.LaptopManufacturer = "Asus";
            TestItem.LaptopQuantity = 10;
            TestItem.LaptopPrice = 10.99;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //add the time to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllLaptops.LaptopsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptops.LaptopsList, TestList);
        }
        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create some test data to assign to the property
            clsLaptops TestLaptop = new clsLaptops();
            //set the properties of the test object
            TestLaptop.LaptopID = 1;
            TestLaptop.LaptopModel = "Slim";
            TestLaptop.LaptopManufacturer = "Asus";
            TestLaptop.LaptopQuantity = 10;
            TestLaptop.LaptopPrice = 10.99;
            TestLaptop.LaptopReorder = true;
            TestLaptop.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //assign the data 
            AllLaptops.ThisLaptop = TestLaptop;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptops.ThisLaptop, TestLaptop);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create some test data
            List<clsLaptops> TestList = new List<clsLaptops>();
            //Add item to list
            clsLaptops TestItem = new clsLaptops();
            //set the properties
            TestItem.LaptopID = 1;
            TestItem.LaptopModel = "Slim";
            TestItem.LaptopManufacturer = "Asus";
            TestItem.LaptopQuantity = 10;
            TestItem.LaptopPrice = 10.99;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //add the item to the test list
            TestList.Add(TestItem);
            //set the address list proprty
            AllLaptops.LaptopsList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptops.Count, TestList.Count);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create the item of test data
            clsLaptops TestItem = new clsLaptops();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.LaptopID = 1;
            TestItem.LaptopModel = "Test";
            TestItem.LaptopManufacturer = "Test";
            TestItem.LaptopQuantity = 7357;
            TestItem.LaptopPrice = 73.57;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //add the item to the test list
            AllLaptops.ThisLaptop = TestItem;
            //add the record
            PrimaryKey = AllLaptops.Add();
            //set the PrimaryKey of the test data
            TestItem.LaptopID = PrimaryKey;
            //find the record
            AllLaptops.ThisLaptop.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptops.ThisLaptop, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create the item of the test data
            clsLaptops TestItem = new clsLaptops();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its proprties
            TestItem.LaptopID = 1;
            TestItem.LaptopModel = "Test";
            TestItem.LaptopManufacturer = "Test";
            TestItem.LaptopQuantity = 7357;
            TestItem.LaptopPrice = 73.57;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //set ThisLaptops to the test data
            AllLaptops.ThisLaptop = TestItem;
            //add the record
            PrimaryKey = AllLaptops.Add();
            //set the primary key of the test data
            TestItem.LaptopID = PrimaryKey;
            //modify the test record
            TestItem.LaptopID = PrimaryKey;
            TestItem.LaptopModel = "Test 2";
            TestItem.LaptopManufacturer = "Test 2";
            TestItem.LaptopQuantity = 111;
            TestItem.LaptopPrice = 12.31;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //set the record based on the new data
            AllLaptops.ThisLaptop = TestItem;
            //update the record
            AllLaptops.Update();
            //find the record
            AllLaptops.ThisLaptop.Find(PrimaryKey);
            //test to see if ThisAddress matches the rest data
            Assert.AreEqual(AllLaptops.ThisLaptop, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create the item of test data
            clsLaptops TestItem = new clsLaptops();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.LaptopID = PrimaryKey;
            TestItem.LaptopModel = "Test Delete";
            TestItem.LaptopManufacturer = "Test Delete";
            TestItem.LaptopQuantity = 222;
            TestItem.LaptopPrice = 12.31;
            TestItem.LaptopReorder = true;
            TestItem.LaptopReorderDate = DateTime.Now.AddMonths(5);
            //set ThisAddress to the test data
            AllLaptops.ThisLaptop = TestItem;
            //add the record
            PrimaryKey = AllLaptops.Add();
            //set the primary key of the test data
            TestItem.LaptopID = PrimaryKey;
            //find the record
            AllLaptops.ThisLaptop.Find(PrimaryKey);
            //delete the record
            AllLaptops.Delete();
            //now find the record
            Boolean Found = AllLaptops.ThisLaptop.Find(PrimaryKey);
            //test to see that the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByManufacturerMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsLaptopsCollection AllLaptops = new clsLaptopsCollection();
            //create an instance of the filtered data
            clsLaptopsCollection FilteredLaptops = new clsLaptopsCollection();
            //apply a blank string (should return all records);
            FilteredLaptops.ReportByManufacturer("");
            //test to see that the two values are the same
            Assert.AreEqual(AllLaptops.Count, FilteredLaptops.Count);
        }
        [TestMethod]
        public void ReportByManufacturerNoneFound()
        {
            //create an instance of the class we want to create
            clsLaptopsCollection FilteredLaptops = new clsLaptopsCollection();
            //apply a manufacturer that doesnt exist
            FilteredLaptops.ReportByManufacturer("xxxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredLaptops.Count);
        }
        [TestMethod]
        public void ReportByManufacturerTestDataFound() 
        {
            //create an instance of the filtered data
            clsLaptopsCollection FilteredLaptops = new clsLaptopsCollection();
            //variable to store the outcome
            Boolean OK = true;
            //apply the test manufacturer
            FilteredLaptops.ReportByManufacturer("Test");
            //check that the correct number of records are found
            if (FilteredLaptops.Count == 2)
            {
                //check if the first record is 1
                if (FilteredLaptops.LaptopsList[0].LaptopID != 1)
                {
                    OK = false;
                }
                //check if the first record is 2
                if (FilteredLaptops.LaptopsList[1].LaptopID != 2)
                {
                    OK = false;
                }
            } else { OK = false; }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
