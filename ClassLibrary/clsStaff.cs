using System;

namespace ClassLibrary
{
    public class clsStaff

    {   //private data member for the address id project
        private Int32 mStaffId;

        //private data memeber for the Staff Name
        private string mStaffName;

        //private data memeber for the Staff Email
        private string mStaffEmail;

        //private data memeber for the Satff Phone Number
        private string mStaffPhoneNumber;

        //private data memeber for the Staff Address
        private string mStaffAddress;

        //private data memeber for the Staff Date of Birth
        private DateTime mDateAdded;

        //private data memeber for the Active
        private Boolean mActive;

        public bool Active {

            //this line sneds the data out of the attribute
            get { return mActive;}

            //This line allows data Int32o the attribute
            set { mActive = value;}
        }

        public DateTime DateAdded {

            //this line sneds the data out of the attribute
            get { return mDateAdded;}

            //This line allows data Int32o the attribute
            set {  mDateAdded = value;}
        }

       
        public Int32 StaffId
        {
            //this line sneds the data out of the attribute
            get { return mStaffId; }

            //This line allows data Int32o the attribute
            set { mStaffId = value; }
        }

        public string StaffAddress {

            //this line sneds the data out of the attribute
            get { return mStaffAddress; }

            //This line allows data Int32o the attribute
            set { mStaffAddress = value; }
        }

        public string StaffName {

            //this line sneds the data out of the attribute
            get { return mStaffName; }

            //This line allows data Int32o the attribute
            set { mStaffName = value; }
        }

        public string StaffPhoneNumber {

            //this line sneds the data out of the attribute
            get { return mStaffPhoneNumber; }

            //This line allows data Int32o the attribute
            set { mStaffPhoneNumber = value; }
        }

        public string StaffEmail {

            //this line sneds the data out of the attribute
            get { return mStaffEmail; }

            //This line allows data Int32o the attribute
            set { mStaffEmail = value; }
        }

        public bool Find(int StaffId)

        {   // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the address id to search for 
            DB.AddParameter("@StaffId", StaffId);

            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            if (DB.Count == 1)
            {   
                //copy the data from database to therespective private variables
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); 

                //return true that everything worked ok 
                return true;
            }

            //if no record is found 
            else

            {   //return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string dateAdded, string staffAddress, string staffName, string staffPhoneNumber, string staffEmail)
        {//create  a string variable to store the error 
           String Error = "";
            //temporary variable to store date 
            DateTime DateComp = DateTime.Now.Date;
            DateTime DateTemp;   
            // if the address is blank
            if(staffAddress.Length == 0)
            {
                //record the error 
                Error = Error + " The staff address should not be blank : ";
            }
            //if the house no is greater than 75
            if (staffAddress.Length > 75) {
                //record the error
                Error = Error + "The staff address should be less than 75 characters : ";
            }
            try
            {
                //copy the dateAdded value to the DateTime variable 
                DateTemp = Convert.ToDateTime(dateAdded);
                // compare dateAdded with DateComp
                if (DateTemp < DateComp)
                {
                    Error = Error + "Date cannot be in past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "Date cannot be in future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : "; 
            }
            if(staffName.Length == 0) {
                Error = Error + "StaffName should not be empty : ";
            }
            if (staffPhoneNumber.Length == 0)
            {
                Error = Error + "StaffPhoneNumber should not be empty : ";
            }
            if (staffEmail.Length == 0)
            {
                Error = Error + "StaffEmail should not be empty : ";
            }
            if (staffName.Length > 45)
            { 
                Error = Error + "StaffName should be less than 45 characters : ";
            }
            if (staffPhoneNumber.Length > 18)
            {
                Error = Error + "StaffPhoneNumber should be less than 18 characters : ";
            }
            if (staffEmail.Length > 30)
            {
                Error = Error + "StaffEamil should be less than 30 characters : ";
            }
            //return any error messages
            return Error;

        }
    }
}

