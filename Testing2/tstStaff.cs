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
    }
}
