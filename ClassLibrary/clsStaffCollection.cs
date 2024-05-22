using System;
using System.Collections.Generic;

namespace ClassLibrary

{
    public class clsStaffCollection
    {  public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while(Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
               AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
               AnStaff.StaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
               AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
               AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
               AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mStaffList.Add(AnStaff);    
                Index++;    
            }
        }
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get { return mStaffList.Count; }
            set { }
        }

        public clsStaff ThisStaff
        {
            get
            { return mThisStaff; }
            set 
            { mThisStaff = value; }
        }
        public int Add()
        {
            //adds a record to the database based on the values of mThisAddress
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);

            return DB.Execute("sproc_tblStaff_Insert");

        }
    }
}