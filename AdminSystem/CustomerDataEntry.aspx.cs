using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //creates a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the customer no
        AnCustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //capture the first name
        AnCustomer.CustFirstName = txtFirstName.Text;
        //capture the last name
        AnCustomer.CustLastName = txtLastName.Text;
        //capture the dob
        AnCustomer.CustDOB = Convert.ToDateTime(DateTime.Now);
        //capture the email
        AnCustomer.CustEmail = txtEmail.Text;
        //capture the address
        AnCustomer.CustAddress = txtAddress.Text;
        //capture the check
        AnCustomer.Has2SV = chkHas2SV.Checked;
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer; 
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

}