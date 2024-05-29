using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class
            clsCustomerUser AnUser = new clsCustomerUser();
            //test to see that it exists
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign a property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign a property
            string TestData = "Kiaran";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign a property
            string TestData = "K123";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPeopertyOK()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign a property
            string TestData = "Customer";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data
            string UserName = "Kiaran";
            string Password = "K123";
            //invoke the mehtod
            Found = AnUser.FindUser(UserName, Password);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class 
            clsCustomerUser AnUser = new clsCustomerUser();
            //create a boolean variable to store the result of the serch
            Boolean Found = false;
            //create a boolean variable to record if the data is ok 
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Kiaran";
            string Password = "K123";
            //invoke the method 
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property 
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
