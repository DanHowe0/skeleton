using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);

    }


    protected void buttonYes_Click(object sender, EventArgs e)
    {
       
       
        clsStaffCollection Staff = new clsStaffCollection();
        Staff.ThisStaff.Find(StaffId);
        Staff.Delete();
        Response.Redirect("StaffList.aspx");

    }

    protected void buttonNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}