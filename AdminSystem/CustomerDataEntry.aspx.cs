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
        //capture the first name
        string CustFirstName = txtFirstName.Text;
        //capture the last name
        string CustLastName = txtLastName.Text;
        //capture the DOB
        string CustDOB = txtDOB.Text;
        //capture the email 
        string CustEmail = txtEmail.Text;
        //capture the address
        string CustAddress = txtAddress.Text;
        //capture the Has2SV check box
        string Has2SV = chkHas2SV.Text;
        //varaible to store any error messages
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(CustFirstName, CustLastName, CustDOB, CustEmail, CustAddress);
        if (Error == "")
        {
            //capture the first name
            AnCustomer.CustFirstName = CustFirstName;
            //capture the last name
            AnCustomer.CustLastName = CustLastName;
            //capture the dob
            AnCustomer.CustDOB = Convert.ToDateTime(CustDOB);
            //capture the email
            AnCustomer.CustEmail = CustEmail;
            //capture the address
            AnCustomer.CustAddress = CustAddress;
            
            //store the address in the session object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");

            //capture the customer no
            //AnCustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a varaible to store pk 
        Int32 CustomerNo;
        //create varaible to store results of the find
        Boolean Found = false;
        //get the pk entered by the user
        CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        //find the record
        Found = AnCustomer.Find(CustomerNo);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.CustFirstName;
            txtLastName.Text = AnCustomer.CustLastName;
            txtDOB.Text = AnCustomer.CustDOB.ToString();
            txtEmail.Text = AnCustomer.CustEmail;
            txtAddress.Text = AnCustomer.CustAddress;
            chkHas2SV.Checked = AnCustomer.Has2SV;
        }
    }
}