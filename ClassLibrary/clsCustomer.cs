using Microsoft.SqlServer.Server;
using System;
using System.Net;
using System.Net.Security;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //private data memeber for the customer no 
        private Int32 mCustomerNo;
        //CustomerNo public property
        public int CustomerNo
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustomerNo;
            }
            set
            {
                //This line allows data Int32o the attribute
                mCustomerNo = value;
            }
        }

        //private for first name
        private string mCustFirstName;
        //First name public property
        public string CustFirstName
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustFirstName;
            }
            set
            {
                //This line allows data Into the attribute
                mCustFirstName = value;
            }
        }

        //private for last name
        private string mCustLastName;
        //Last name public property
        public string CustLastName
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustLastName;
            }
            set
            {
                //This line allows data Into the attribute
                mCustLastName = value;
            }
        }

        //private for email
        private string mCustEmail;
        //email public property
        public string CustEmail
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustEmail;
            }
            set
            {
                //This line allows data Into the attribute
                mCustEmail = value;
            }
        }
        //private for address
        private string mCustAddress; 
        //address public property
        public string CustAddress
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustAddress;
            }
            set
            {
                //This line allows data Into the attribute
                mCustAddress = value;
            }
        }

        //private data memeber for the 2SV
        private Boolean mHas2SV;
        //Has2SV public property
        public bool Has2SV
        {
            get
            {
                //this line sends the data out of the attribute
                return mHas2SV;
            }
            set
            {
                //This line allows data Int32o the attribute
                mHas2SV = value;
            }
        }

        //priavte for DOB
        private DateTime mCustDOB;
        //DOB public property
        public DateTime CustDOB
        {
            get
            {
                //this line sends the data out of the attribute
                return mCustDOB;
            }
            set
            {
                //This line allows data Into the attribute
                mCustDOB = value;
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
                mCustFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustFirstName"]);
                mCustLastName = Convert.ToString(DB.DataTable.Rows[0]["CustLastName"]);
                mCustEmail = Convert.ToString(DB.DataTable.Rows[0]["CustEmail"]);
                mCustAddress = Convert.ToString(DB.DataTable.Rows[0]["CustAddress"]);
                mHas2SV = Convert.ToBoolean(DB.DataTable.Rows[0]["Has2SV"]);
                mCustDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustDOB"]);
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
        public string Valid(string custFirstName, string custLastName, string custEmail, string custAddress, string custDOB)
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
            //if the customer first name is greater then 15 char
            if (custFirstName.Length > 15)
            {
                //record the error 
                Error = Error + " the first name must be less than 15 chracters : "; 
            }

            //if the last name is blank 
            if (custLastName.Length == 0)
            {
                //record the error 
                Error = Error + "The customer last name may not be blank : ";
            }
            //if the customer last name is greater then 15 char
            if (custLastName.Length > 15)
            {
                //record the error 
                Error = Error + " the last name must be less than 15 chracters : ";
            }

            //if the email is blank
            if (custEmail.Length == 0)
            {
                //record the error 
                Error = Error + "The email needs to be filled in : ";
            }
            //if the customer email is greater then 20 char
            if (custEmail.Length > 20)
            {
                //record the error 
                Error = Error + " the email must be less than 20 chracters : ";
            }

            //if the address is blank
            if (custAddress.Length == 0)
            {
                //record the error 
                Error = Error + "The address may not be blank : ";
            }
            //if the customer address is greater then 20 char
            if (custAddress.Length > 20)
            {
                //record the error 
                Error = Error + " the address must be less than 20 chracters : ";
            }

            //create an instance of DateTime to compare with date temp 
            //in the if statement
            DateTime DateComp = DateTime.Now.Date;
            try
            { 
                //copy the dateAdded value to the DateTemp varibale
                DateTemp = Convert.ToDateTime(custDOB);
                //check to see if the DOB added is younger than 15 years from todays date
                if (DateTemp > DateComp.AddYears(-15))
                {
                    Error = Error + "The birth date must be 15 years or older : ";
                }
                //checks to see if the DOB added is grater than today's date.
                if (DateTemp >= DateComp)
                {
                    Error = Error + "The birth date cannot be in the future : ";
                }
                //checks to see if the DOB is too far in the past (200 years) 
                if (DateComp < DateComp.AddYears(-200))
                {
                    Error = Error + "The DOB can not be that far in the past : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date was not valid a date : ";
            }

            //return any error messages 
            return Error;

        }





    }
}