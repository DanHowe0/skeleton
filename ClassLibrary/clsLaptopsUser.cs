using System;

namespace ClassLibrary
{
    public class clsLaptopsUser
    {

        //private data members
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;


        public int UserID { get { return mUserID; } set { mUserID = value; } }
        public string UserName { get { return mUserName; } set { mUserName = value; } }
        public string Password { get { return mPassword; } set { mPassword = value; } }
        public string Department { get { return mDepartment; } set { mDepartment = value; } }

        public bool FindUser(string userName, string password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the paramethers for the sproc
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the sproc
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if only one record is found
            if (DB.Count == 1)
            {
                //copy the data to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything ok
                return true;
            }
            else 
            { 
                return false; 
            }
        }
    }
}