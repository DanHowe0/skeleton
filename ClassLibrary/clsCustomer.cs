using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public clsCustomer()
        {
        }

        public bool Has2SV { get; set; }
        public int CustomerNo { get; set; }
        public string CustFirstName { get; set; }
        public string CustLastName { get; set; }
        public DateTime CustDOB { get; set; }
        public string CustEmail { get; set; }
        public string CustAddress { get; set; }
    }
}