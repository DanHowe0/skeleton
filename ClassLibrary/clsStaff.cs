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

        public bool Find(Int32 StaffId)

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
                mStaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["StaffPhoneNumber"]);
                mStaffEmail = Convert.ToString(DB.DataTable.Rows[0]["StaffEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDateofBirth"]);
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
    }
}

