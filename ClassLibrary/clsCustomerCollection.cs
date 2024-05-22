using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {

        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private member data for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();
        
        //public property for the address list
        public List<clsCustomer> CustomerList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }     
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //do later
            }
        }
        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data 
                return mThisCustomer;
            }
            set
            {
                //set the private data 
                mThisCustomer = value;
            }
        }

        public clsCustomerCollection()
        {
            //variable for the index 
            Int32 Index = 0;
            //varibale to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get record count
            RecordCount = DB.Count;
            //while records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields for the current records
                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Has2SV = Convert.ToBoolean(DB.DataTable.Rows[Index]["Has2SV"]);
                AnCustomer.CustFirstName = Convert.ToString(DB.DataTable.Rows[Index]["CustFirstName"]);
                AnCustomer.CustLastName = Convert.ToString(DB.DataTable.Rows[Index]["CustLastName"]);
                AnCustomer.CustEmail = Convert.ToString(DB.DataTable.Rows[Index]["CustEmail"]);
                AnCustomer.CustAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustAddress"]);
                AnCustomer.CustDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustDOB"]);
                //add the record to the privae data member
                mCustomerList.Add(AnCustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of the mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sored procedure
            DB.AddParameter("@CustFirstName", mThisCustomer.CustFirstName);
            DB.AddParameter("@CustLastName", mThisCustomer.CustLastName);
            DB.AddParameter("@CustDOB", mThisCustomer.CustDOB);
            DB.AddParameter("@CustEmail", mThisCustomer.CustEmail);
            DB.AddParameter("@CustAddress", mThisCustomer.CustAddress);
            DB.AddParameter("@Has2SV", mThisCustomer.Has2SV);

            //execute the query returning the PK key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //adds a record to the database based on the values of the mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the sored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@CustFirstName", mThisCustomer.CustFirstName);
            DB.AddParameter("@CustLastName", mThisCustomer.CustLastName);
            DB.AddParameter("@CustDOB", mThisCustomer.CustDOB);
            DB.AddParameter("@CustEmail", mThisCustomer.CustEmail);
            DB.AddParameter("@CustAddress", mThisCustomer.CustAddress);
            DB.AddParameter("@Has2SV", mThisCustomer.Has2SV);

            //execute the query returning the PK key value
             DB.Execute("sproc_tblCustomer_Update");
        }
    }
}