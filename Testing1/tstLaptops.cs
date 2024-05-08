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
    }
}
