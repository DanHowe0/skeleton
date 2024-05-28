using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted
    Int32 LaptopId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the laptop deleted from the session object
        LaptopId = Convert.ToInt32(Session["LaptopId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address bot collection class
        clsLaptopsCollection Laptops = new clsLaptopsCollection();
        //find the record to delete
        Laptops.ThisLaptop.Find(LaptopId);
        //delete the record
        Laptops.Delete();
        //redirect back to the main page
        Response.Redirect("LaptopsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("LaptopsList.aspx");
    }
}