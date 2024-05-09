using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the customer no for the entry
        Response.Write(AnCustomer.CustomerNo);
        //display the first name
        Response.Write(AnCustomer.CustFirstName);
        //display the last name
        Response.Write(AnCustomer.CustLastName);
        //display the dob
        Response.Write(AnCustomer.CustDOB);
        //display the email
        Response.Write(AnCustomer.CustEmail);
        //diaplay the address
        Response.Write(AnCustomer.CustAddress);
        //display the check
        Response.Write(AnCustomer.Has2SV);
        
    }
}