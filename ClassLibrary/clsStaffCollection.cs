using System;
using System.Collections.Generic;
using System.Data.Common;

namespace ClassLibrary

{
    public class clsStaffCollection
    {  public clsStaffCollection()
        {
           // Int32 Index = 0;
            //Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
           // RecordCount = DB.Count;
           // while(Index < RecordCount)
            {
              //  clsStaff AnStaff = new clsStaff();
               // AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                //AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
           //    AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
             //   AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
              //  AnStaff.StaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
             //   AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
             //  AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
               // mStaffList.Add(AnStaff);    
              //  Index++;    
              //populate the array list with the data table
              PopulateArray(DB);
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

        public int Update()
        {//adds a record to the database based on the values of mThisAddress
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //set parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffEmail", mThisStaff.StaffEmail);
            DB.AddParameter("@StaffPhoneNumber", mThisStaff.StaffPhoneNumber);
            DB.AddParameter("@DateAdded", mThisStaff.DateAdded);
            DB.AddParameter("@Active", mThisStaff.Active);

            return DB.Execute("sproc_tblStaff_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.Execute("sproc_tblStaff_Delete");
        }

        public void ReportByName(string StaffName)
        {
            clsDataConnection DB = new clsDataConnection();
            //send the Name parameter to the database
            DB.AddParameter("@StaffName", StaffName);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByName");
            //populate the array list with the data table 
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //variable for index 
            Int32 Index = 0 ;
            //variable records to process 
            Int32 RecordCount;
            //get the count of records 
            RecordCount = DB.Count ;
            //clear the private array list
            mStaffList = new List<clsStaff>() ;
            //while there are records to process
            while (Index < RecordCount)
            { // create a blank staff object
                clsStaff AnStaff = new clsStaff() ;
           
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.StaffAddress = Convert.ToString(DB.DataTable.Rows[Index]["StaffAddress"]);
                AnStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AnStaff.StaffEmail = Convert.ToString(DB.DataTable.Rows[Index]["StaffEmail"]);
                AnStaff.StaffPhoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["StaffPhoneNumber"]);
                AnStaff.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                mStaffList.Add(AnStaff);
                Index++;

            }
        }
    }
}