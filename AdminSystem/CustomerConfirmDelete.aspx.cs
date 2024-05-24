using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the Pk value of the new record to delete
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Customer to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of a customer collection class
        clsCustomerCollection Customer = new clsCustomerCollection();
        //find the record to delete 
        Customer.ThisCustomer.Find(CustomerNo);
        //delete the record
        Customer.Delete();
        //redirect back to main page 
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main page 
        Response.Redirect("CustomerList.aspx");
    }
}