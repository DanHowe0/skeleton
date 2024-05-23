using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 staffid;
    protected void Page_Load(object sender, EventArgs e)
    {
        staffid = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false)
        {
            if(staffid != -1)
            {
                DisplayName();
            }
        }

    }



    protected void btnOK_Click(object sender, EventArgs e)
    {  //create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        string staffaddress = txtStaffAddress.Text;
        //capture the StaffName
        string staffname = txtStaffName.Text;
        //capture the StaffEmail
        string staffemail = txtStaffEmail.Text;
        //capture the StaffPhoneNumber
        string staffphonenumber = txtStaffPhoneNumber.Text;
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
            AnStaff.StaffId = staffid;
            AnStaff.StaffAddress = staffaddress;
            AnStaff.StaffName = staffname;
            AnStaff.StaffEmail = staffemail;
            AnStaff.StaffPhoneNumber = staffphonenumber;
            AnStaff.DateAdded = Convert.ToDateTime(dateadded);
            AnStaff.Active = chkActive.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            //if this is a new record of the staff collection
            if (staffid == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(staffid);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();
            }
           
            
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
            txtStaffName.Text = AnStaff.StaffName;
            txtStaffEmail.Text = AnStaff.StaffEmail;
            txtStaffPhoneNumber.Text = AnStaff.StaffPhoneNumber;
            txtDateAdded.Text=AnStaff.DateAdded.ToString();
            chkActive.Checked = AnStaff.Active;
            
        }

    }
    void DisplayName()
    {
        //Int32 StaffId;
        //StaffId = Convert.ToInt32(StaffId);
        clsStaffCollection staff = new clsStaffCollection();
        staff.ThisStaff.Find(staffid);
        txtStaffId.Text = staff.ThisStaff.StaffId.ToString();
        txtStaffAddress.Text = staff.ThisStaff.StaffAddress.ToString();
        txtStaffName.Text = staff.ThisStaff.StaffName.ToString();
        txtStaffEmail.Text = staff.ThisStaff.StaffEmail.ToString();
        txtStaffPhoneNumber.Text = staff.ThisStaff.StaffPhoneNumber.ToString();
        txtDateAdded.Text= staff.ThisStaff.DateAdded.ToString();
        chkActive.Checked= staff.ThisStaff.Active;
    }

}