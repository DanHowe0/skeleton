using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //varaible to store the PK within page loader scope
    Int32 CustomerNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
        if (IsPostBack == false)
        {
            //if this is the not a new record
            if (CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    void DisplayCustomer()
    {
        //create an instance of the address book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);
        //display the data for the record
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.CustFirstName.ToString();
        txtLastName.Text = CustomerBook.ThisCustomer.CustLastName.ToString();
        txtDOB.Text = CustomerBook.ThisCustomer.CustDOB.ToString();
        txtEmail.Text = CustomerBook.ThisCustomer.CustEmail.ToString();
        txtAddress.Text = CustomerBook.ThisCustomer.CustAddress.ToString();
        chkHas2SV.Checked = CustomerBook.ThisCustomer.Has2SV;
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
        Error = AnCustomer.Valid(CustFirstName, CustLastName, CustEmail, CustAddress, CustDOB);
        if (Error == "")
        {
            //capture the CustomerNo
            AnCustomer.CustomerNo = CustomerNo;
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
            //capture the Has2SV
            AnCustomer.Has2SV = chkHas2SV.Checked;
            //create a new instance of the address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e CustomerNo = -1 then add the data
            if (CustomerNo == -1)
            {
                //set the ThisCustomer proprty
                CustomerList.ThisCustomer = AnCustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = AnCustomer;
                //update the record 
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");

            //store the customer in the session object
            Session["AnCustomer"] = AnCustomer;
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