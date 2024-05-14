using Microsoft.SqlServer.Server;
using System;
using System.Net.Security;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for the customer no 
        private Int32 mCustomerNo;

        //private data memeber for the 2SV
        private Boolean mHas2SV;

        //private for first name
        private String mCustFirstName;

        //private for last name
        private string mCustLastName;

        //priavte for DOB
        private DateTime mCustDOB;

        //private for email
        private string mCustEmail;

        //private for address
        private string mCustAddress; 

        public clsCustomer()
        {
        }

        public bool Has2SV
        {
            get
            {
                //this line sneds the data out of the attribute
                return mHas2SV;
            }
            set
            {
                //This line allows data Int32o the attribute
                mHas2SV = value;
            }
        }

        public Int32 CustomerNo
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustomerNo;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustomerNo = value;
            }
        }
        public string CustFirstName
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustFirstName;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustFirstName = value;
            }
        }

        public string CustLastName
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustLastName;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustLastName = value;
            }
        }

        public DateTime CustDOB
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustDOB;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustDOB = value;
            }
        }

        public string CustEmail
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustEmail;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustEmail = value;
            }
        }
        public string CustAddress
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustAddress;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustAddress = value;
            }
        }

        public bool Find(Int32 CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            //if one record is found should be 1 or 0
            if (DB.Count == 1)
            {
                //set the private data members to the test data value
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mHas2SV = Convert.ToBoolean(DB.DataTable.Rows[0]["Has2SV"]);
                mCustFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustFirstName"]);
                mCustLastName = Convert.ToString(DB.DataTable.Rows[0]["CustLastName"]);
                mCustDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustDOB"]);
                mCustEmail = Convert.ToString(DB.DataTable.Rows[0]["CustEmail"]);
                mCustAddress = Convert.ToString(DB.DataTable.Rows[0]["CustAddress"]);
                //return everything is ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false (there is a problem)
                return false;
            }

        }

        //function for the public validation
        public string Valid(string custFirstName, string custLastName, string custDOB, string custEmail, string custAddress)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary varaible to store the date values
            DateTime DateTemp;
            //if the first name is blank
            if (custFirstName.Length == 0)
            {
                //record the error 
                Error = Error + "The customer first name may not be blank : ";
            }
            //if the customer first name is greater then 50 char
            if (custFirstName.Length > 50)
            {
                //record the error 
                Error = Error + " the first name must be less than 50 chracters : "; 
            }

            //if the last name is blank 
            if (custLastName.Length == 0)
            {
                //record the error 
                Error = Error + "The customer last name may not be blank : ";
            }
            //if the customer last name is greater then 50 char
            if (custLastName.Length > 50)
            {
                //record the error 
                Error = Error + " the last name must be less than 50 chracters : ";
            }

            //if the email is blank
            if (custEmail.Length == 0)
            {
                //record the error 
                Error = Error + "The email may not be blank : ";
            }
            //if the customer email is greater then 50 char
            if (custEmail.Length > 50)
            {
                //record the error 
                Error = Error + " the email must be less than 50 chracters : ";
            }

            //if the address is blank
            if (custAddress.Length == 0)
            {
                //record the error 
                Error = Error + "The address may not be blank : ";
            }
            //if the customer address is greater then 50 char
            if (custAddress.Length > 50)
            {
                //record the error 
                Error = Error + " the address must be less than 50 chracters : ";
            }

            //create an instance of DateTime to compare with date temp 
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            { 
                //copy the dateAdded value to the DateTemp varibale
                DateTemp = Convert.ToDateTime(custDOB);
                //check to see if the date is less then today's date
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
                if (DateTemp < DateComp)
                {
                    Error = Error + "The DOB must be 15 years or older : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not valid date : ";
            }

            //return any error messages 
            return Error;

        }





    }
}