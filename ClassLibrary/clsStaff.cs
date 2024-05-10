using System;

namespace ClassLibrary
{
    public class clsStaff
    {//private data member for the address id project
        private int mStaffId;
        private string mStaffName;
        private string mStaffEmail;
        private string mStaffPhoneNumber;
        private string mStaffAddress;
        private DateTime mDateAdded;
        private Boolean mActive;

        public bool Active { 
            get {return mActive;}
            set { mActive = value;}
        }

        public DateTime DateAdded { 
            get { return mDateAdded;}
            set {  mDateAdded = value;}
        }

       
        public Int32 StaffId
        {
            get { return mStaffId; }
            set { mStaffId = value; }
        }

        public string StaffAddress { 
            get { return mStaffAddress; }
            set { mStaffAddress = value; }
        }

        public string StaffName {
            get { return mStaffName; }
            set { mStaffName = value; }
        }

        public string StaffPhoneNumber { 
            get { return mStaffPhoneNumber; }
            set { mStaffPhoneNumber = value; }
        }

        public string StaffEmail { 
            get { return mStaffEmail; }
            set { mStaffEmail = value; }
        }

        public bool Find(int StaffId)
        { // create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id to search for 
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if (DB.Count == 1)
            {//copy the data from database to therespective private variables
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mStaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateofBirth"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]); ;
                //return true that everything worked ok 
                return true;
            }
            //if no record is found 
            else
            {//return false indicating there is a problem
                return false;
            }
        }
    }
}

