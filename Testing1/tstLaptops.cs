using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstLaptops
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //test to see that it exists
            Assert.IsNotNull(aLaptop);
        }
        [TestMethod]
        public void LaptopIDOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            int LaptopID = 1;
            //assign the data to the proprty
            aLaptop.LaptopID = LaptopID;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopID, LaptopID);
        }
        [TestMethod]
        public void LaptopModelOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            String LaptopModel = "X81283BY";
            //assign the data to the proprty
            aLaptop.LaptopModel = LaptopModel;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopModel, LaptopModel);
        }
        [TestMethod]
        public void LaptopManufacturerOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            String LaptopManufacturer = "Asus";
            //assign the data to the proprty
            aLaptop.LaptopManufacturer = LaptopManufacturer;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopManufacturer, LaptopManufacturer);
        }
        [TestMethod]
        public void LaptopQuantityOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            int LaptopQuantity = 10;
            //assign the data to the proprty
            aLaptop.LaptopQuantity = LaptopQuantity;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopQuantity, LaptopQuantity);
        }
        [TestMethod]
        public void LaptopPriceOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            Double LaptopPrice = 199.99;
            //assign the data to the proprty
            aLaptop.LaptopPrice = LaptopPrice;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopPrice, LaptopPrice);
        }
        [TestMethod]
        public void LaptopReorderOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            Boolean LaptopReorder = false;
            //assign the data to the proprty
            aLaptop.LaptopReorder = LaptopReorder;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopReorder, LaptopReorder);
        }
        [TestMethod]
        public void LaptopReorderDateOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            DateTime LaptopReorderDate = DateTime.Now.Date;
            //assign the data to the proprty
            aLaptop.LaptopReorderDate = LaptopReorderDate;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.LaptopReorderDate, LaptopReorderDate);
        }

        [TestMethod]
        public void LaptopFindMethodOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a Boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 LaptopID = 1;
            //invoke the method
            Found = aLaptop.Find(LaptopID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestLaptopIDFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLaptopModelFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopModel != "Slick")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLaptopManufacturerFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopManufacturer != "Intel")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLaptopQuantityFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopQuantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLaptopPriceFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopPrice != 100.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLaptopReorderFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopReorder != false)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLaptopReorderDateFound()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data
            Int32 LaptopID = 1;
            //invoke the method
            found = aLaptop.Find(LaptopID);
            //check the address id
            if (aLaptop.LaptopReorderDate != Convert.ToDateTime("25/12/2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
