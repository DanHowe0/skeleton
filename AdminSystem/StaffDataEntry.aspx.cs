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



    protected void btnOK_Click(object sender, EventArgs e)
    {  //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the StaffName
        string staffname = txtStaffName.Text;
        //capture the StaffEmail
        string staffemail = txtStaffEmail.Text;
        //capture the StaffPhoneNumber
        string staffphonenumber = txtStaffPhoneNumber.Text;
        //capture the StaffAddress
        string staffaddress = txtStaffAddress.Text;
        //capture the DateOfBirth
        string dateadded = txtDateAdded.Text;
        //capture the active 
        string active = chkActive.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AnStaff.Valid(dateadded, staffaddress, staffname, staffphonenumber, staffemail);
        if (Error == "")
        {
            AnStaff.Active = chkActive.Checked;
            AnStaff.StaffName = staffname;
            AnStaff.StaffEmail = staffemail;
            AnStaff.StaffAddress = staffaddress;    
            AnStaff.StaffPhoneNumber = staffphonenumber;
            AnStaff.DateAdded = Convert.ToDateTime(dateadded);
            clsStaffCollection StaffList = new clsStaffCollection();
            StaffList.ThisStaff = AnStaff;
            StaffList.Add();
            
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            txtDateAdded.Text=AnStaff.DateAdded.ToString();
            chkActive.Checked = AnStaff.Active;
            
        }

    }
}