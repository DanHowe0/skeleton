using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        { 
            DisplayName();
        }
        clsStaffUser AnUser = new clsStaffUser();
        AnUser = (clsStaffUser)Session["AnUser"];
        Response.Write("Logged in as : " + AnUser.UserName);
    }
    void DisplayName()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of address in the collection 
        lstStaffList.DataSource = Staffs.StaffList;
        //set the primary key
        lstStaffList.DataValueField = "StaffId";
        //data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to list
        lstStaffList.DataBind();
    }

    

   

  

    protected void buttonEdit_Click1(object sender, EventArgs e)
    {
         Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {//get the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    

    protected void buttonAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void buttonDelete_Click1(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }

    }

    

 

    protected void ApplyFilter_Click1(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of the post code from the presentation layer 
        AnStaff.ReportByName(txtFilter.Text);
        //set the data source to the list of the name in the colllection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the field to display 
        lstStaffList.DataValueField = "StaffId";
        //set name of the field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();

    }

    protected void ClearFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection AnStaff = new clsStaffCollection();
        //retrieve the value of the post code from the presentation layer 
        AnStaff.ReportByName(txtFilter.Text);
        txtFilter.Text = "";
        //set the data source to the list of the name in the colllection
        lstStaffList.DataSource = AnStaff.StaffList;
        //set the name of the field to display 
        lstStaffList.DataValueField = "StaffId";
        //set name of the field to display 
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();


    }

    protected void btnReturnTomainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}