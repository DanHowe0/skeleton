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
       
       
    }
}