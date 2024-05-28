using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
    }
}
