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

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {  //create a new instance of clsStaff
       clsStaff AnStaff = new clsStaff();
        //capture the StaffName
        AnStaff.StaffName = txtStaffName.Text;
        //store the address in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the view page 
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {//create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
       //create a variable to store the result of the find operation
       Boolean Found = false;
        //get the primary key entered by user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record 
        Found = AnStaff.Find(StaffId);
        //if Found
       if (Found == true) {
            txtStaffAddress.Text = AnStaff.StaffAddress;
            txtStaffEmail.Text = AnStaff.StaffEmail;
            txtStaffName.Text = AnStaff.StaffName;  
            txtStaffPhoneNumber.Text = AnStaff.StaffPhoneNumber;
            txtStaffDOB.Text=AnStaff.DateAdded.ToString();
            chkActive.Checked = AnStaff.Active;
            
        }

    }
}