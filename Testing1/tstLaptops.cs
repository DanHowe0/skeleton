using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
            int ID = 1;
            //assign the data to the proprty
            aLaptop.ID = ID;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.ID, ID);
        }
        [TestMethod]
        public void LaptopModelOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            String Model = "X81283BY";
            //assign the data to the proprty
            aLaptop.Model = Model;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.Model, Model);
        }
        [TestMethod]
        public void LaptopManufacturerOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            String Manufacturer = "Asus";
            //assign the data to the proprty
            aLaptop.Manufacturer = Manufacturer;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.Manufacturer, Manufacturer);
        }
        [TestMethod]
        public void LaptopQuantityOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            int Quantity = 10;
            //assign the data to the proprty
            aLaptop.Quantity = Quantity;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.Quantity, Quantity);
        }
        [TestMethod]
        public void LaptopPriceOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            Double Price = 199.99;
            //assign the data to the proprty
            aLaptop.Price = Price;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.Price, Price);
        }
        [TestMethod]
        public void LaptopReorderOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            Boolean Reorder = false;
            //assign the data to the proprty
            aLaptop.Reorder = Reorder;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.Reorder, Reorder);
        }
        [TestMethod]
        public void LaptopReorderDateOK()
        {
            //create an instance of the class we want to create
            clsLaptops aLaptop = new clsLaptops();
            //create some test data to assign to the property
            DateTime ReorderDate = DateTime.Now.Date;
            //assign the data to the proprty
            aLaptop.ReorderDate = ReorderDate;
            //test to see that the two values are the same
            Assert.AreEqual(aLaptop.ReorderDate, ReorderDate);
        }

    }
}
