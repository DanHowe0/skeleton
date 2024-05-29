using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsStaffUser AnUser = new clsStaffUser();
            Int32 TestData = 1;
            AnUser.UserId = TestData;
            Assert.AreEqual(AnUser.UserId, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Divyansh";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "D@28";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
           
         Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffUser AnUser = new clsStaffUser();
            //create some test data to assign to the property
            string TestData = "Staff";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserPropertyOK() {
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            string UserName = "Divyansh";
            string Password = "D@28";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestUserNamePWFFound() 
        { 
            clsStaffUser AnUser = new clsStaffUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Divyansh";
            string Password = "D@28";
            Found = AnUser.FindUser(UserName,Password);
            if(AnUser.UserName!= UserName && AnUser.Password!= Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}
