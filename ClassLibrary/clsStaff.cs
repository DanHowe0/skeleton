using System;

namespace ClassLibrary
{
    public class clsStaff
    {//private data member for the address id project
        private Int32 mStaffId;
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

        public bool Find(Int32 StaffId)
        {
            mStaffId = 1;
            mStaffAddress = "123";
            mStaffName = "Divyansh";
            mStaffPhoneNumber = "7867029044";
            mStaffEmail = "divyanshsingh1800@gmail.com";
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mActive = true;

            return true;
        }
    }
}

