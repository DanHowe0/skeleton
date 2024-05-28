using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstLaptops
    {
        //good test data
        //create some test data to pass the method
        string laptopModel = "Slick";
        string laptopManufacturer = "Intel";
        string laptopQuantity = "10";
        string laptopPrice = "999.99";
        string laptopReorderDate = DateTime.Now.AddDays(30).ToShortDateString();
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
        [TestMethod]
        public void ValidMethodOkay()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void LaptopModelMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "a";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "aa";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            laptopModel = laptopModel.PadRight(49, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            laptopModel = laptopModel.PadRight(50, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            laptopModel = laptopModel.PadRight(51, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMid()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            laptopModel = laptopModel.PadRight(25, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopModelMaxExtreme()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopModel = "";
            laptopModel = laptopModel.PadRight(500, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        public void LaptopManufacturerMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "a";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "aa";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            laptopManufacturer = laptopManufacturer.PadRight(49, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            laptopManufacturer = laptopManufacturer.PadRight(50, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            laptopManufacturer = laptopManufacturer.PadRight(51, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMid()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            laptopManufacturer = laptopManufacturer.PadRight(25, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopManufacturerMaxExtreme()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            // string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string laptopManufacturer = "";
            laptopManufacturer = laptopManufacturer.PadRight(500, 'a');
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateExtemeMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was yesterday plus 30 days
            TestDate = TestDate.AddDays(-1);
            TestDate = TestDate.AddDays(30);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is today plus 30 days
            TestDate = TestDate.AddDays(30);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is tomorrow plus 30 days
            TestDate = TestDate.AddDays(1);
            TestDate = TestDate.AddDays(30);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMid()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is in 6 months
            TestDate = TestDate.AddMonths(6);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was yesterday plus 1 year
            TestDate = TestDate.AddDays(-1);
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is today plus 1 year
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is tomorrow plus 1 year
            TestDate = TestDate.AddDays(1);
            TestDate = TestDate.AddYears(1);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date was today plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string laptopReorderDate = TestDate.ToString();
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopReorderDateInvalidDataType()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test date data
            String laptopReorderDate;
            //set the date to the invalid data
            laptopReorderDate = "Hello World";
            //invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityExtremeMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "-100";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "-1";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "0";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "1";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMid()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "500";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMaxLessOone()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "999";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "1000";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "1001";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to seee tha the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "1000000";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityInvalidDataType()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "Hello World!";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityIntegerLimit()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "2,147,483,647";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopQuantityIntegerLimitPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopQuantity = "2,147,483,648";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceExtremeMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "-1000.00";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "-0.01";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMin()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "0.00";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "0.01";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMid()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "50000.00";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "999999.99";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "1000000.00";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "1000000.01";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceExtremeMax()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "1000000000.00";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void LaptopPriceInvalidDataType()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //string variable to store any error messages
            String Error = "";
            //create a variable to store the test data
            String laptopPrice = "Hello World!";
            //Invoke the method
            Error = aLaptop.Valid(laptopModel, laptopManufacturer, laptopQuantity, laptopPrice, laptopReorderDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}
