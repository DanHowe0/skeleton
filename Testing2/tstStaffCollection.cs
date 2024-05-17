using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstStaffCollection
    {
        public List<clsStaff> StaffList { get; private set; }

        [TestMethod]
        public void InstanceOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);

        }
        [TestMethod]
        public void SatffListOk() {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff>TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffAddress = "Ben Russell";
            TestItem.StaffName = "Abdullah";
            TestItem.StaffPhoneNumber = "07867029043";
            TestItem.StaffEmail = "abdullah@gmail.com";
            TestItem.StaffId = 1;
            TestItem.Active = true;
            TestList.Add(TestItem); 
            AllStaff.StaffList= TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.DateAdded = DateTime.Now;
            TestItem.StaffAddress = "Ben Russell";
            TestItem.StaffName = "Abdullah";
            TestItem.StaffPhoneNumber = "07867029043";
            TestItem.StaffEmail = "abdullah@gmail.com";
            TestItem.StaffId = 1;
            TestItem.Active = true;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
      
   
    }
}
