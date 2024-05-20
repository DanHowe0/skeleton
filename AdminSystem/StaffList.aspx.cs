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
            DisplayAddress();
        }
    }
    void DisplayAddress()
    {
        clsStaffCollection Staffs = new clsStaffCollection();
        //set the data source to list of address in the collection 
        lstStaffList.DataSource = Staffs.StaffList;
        //set the primary key
        lstStaffList.DataTextField = "StaffId";
        //data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to list
        lstStaffList.DataBind();
    }

    protected void buttonAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AddressId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }
}