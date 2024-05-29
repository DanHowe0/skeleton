using Microsoft.SqlServer.Server;
using System;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data memeber for the user id property
        private Int32 mUserID;
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data 
                mUserID = value;
            }
        }
        //private data memeber for the username property
        private String mUserName;
        public string UserName
        {
            get
            {
                //return the private data 
                return mUserName;
            }
            set
            {
                //set the private data 
                mUserName = value;
            }
        }
        //private data member for the password property
        private string mPassword;
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data 
                mPassword = value;
            }
        }
        //private data memeber for the department property
        private string mDepartment;
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data 
                mDepartment = value;
            }
        }

        public bool FindUser(string UserName, string Password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add parameters for the user username and password to serach for 
            DB.AddParameter("@UserName", UserName);
            DB.AddParameter("@Password", Password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindCustUserNamePW");
            //if one record is found 
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members 
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything is ok
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}