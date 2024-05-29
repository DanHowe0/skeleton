using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstLaptopsUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIDPropertyOK() 
        {
            //create an instance of the class we want create
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want create
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create some test data to assign to the property
            string TestData = "Dan";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want create
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create some test data to assign to the property
            string TestData = "Dan123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want create
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create some test data to assign to the property
            string TestData = "Laptops";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK() 
        {
            //creat an instance of the class
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create a bool to store results of validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Divyansh";
            string Password = "D@28";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound() 
        {
            //create an instance of the class
            clsLaptopsUser AnUser = new clsLaptopsUser();
            //create a bool to store the result of the search
            Boolean Found = false;
            //create a bool to record if data is ok
            Boolean OK = true;
            //creat some test data to use with the method
            string UserName = "Dan";
            string Password = "Dan123";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the users property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
