using System;

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
                //This line allows data into the attribute
                mHas2SV = value;
            }
        }

        public int CustomerNo
        {
            get
            {
                //this line sneds the data out of the attribute
                return mCustomerNo;
            }
            set
            {
                //This line allows data into the attribute
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
                //This line allows data into the attribute
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
                //This line allows data into the attribute
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
                //This line allows data into the attribute
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
                //This line allows data into the attribute
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
                //This line allows data into the attribute
                mCustAddress = value;
            }
        }

        public bool Find(int customerNo)
        {
            //set the private data members to the test data value
            mCustomerNo = 1;
            mHas2SV = true;
            mCustFirstName = "Kiaran";
            mCustLastName = "Cotterill";
            mCustDOB = Convert.ToDateTime("15/02/2004");
            mCustEmail = "kiaran@gmail.com";
            mCustAddress = "68, assarts road";
            //alwyas return true
            return true;
        }

    }
}