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
    }
}
