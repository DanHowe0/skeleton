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
        //if this is the first time the page is displayes
        if (IsPostBack == false)
        {
            //update the list box
            DisplayLaptops();
            //set the user
            clsLaptopsUser User = (clsLaptopsUser)Session["User"];
            lblUser.Text = "Logged in as: " + User.UserName;
        }
    }

    void DisplayLaptops()
    {
        //create an instance of the Laptop Collection
        clsLaptopsCollection Laptops = new clsLaptopsCollection();
        //set the data source to the list of addresses in the collection
        lstLaptopsList.DataSource = Laptops.LaptopsList;
        //set the name of the primary key
        lstLaptopsList.DataValueField = "LaptopID";
        //set the data to display
        lstLaptopsList.DataTextField = "LaptopModel";
        //bind the data to the list
        lstLaptopsList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate that this is a new record
        Session["LaptopId"] = -1;
        //redirect to the data entry page
        Response.Redirect("LaptopsDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primarry key balue of the selected record
        Int32 LaptopId;
        //if a record has been selected from the list
        if (lstLaptopsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            LaptopId = Convert.ToInt32(lstLaptopsList.SelectedValue);
            //store the data in the session object
            Session["LaptopId"] = LaptopId;
            //redirect to the edit page
            Response.Redirect("LaptopsDataEntry.aspx");
        } else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 LaptopID;
        //if a record has been selected from the list
        if (lstLaptopsList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            LaptopID = Convert.ToInt32(lstLaptopsList.SelectedValue);
            //store the data in the session object
            Session["LaptopId"] = LaptopID;
            //redirect to the delete page
            Response.Redirect("LaptopsConfirmDelete.aspx");
        }
        else // if no record is selected
        {
            //display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilterApply_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsLaptopsCollection FilteredLaptops = new clsLaptopsCollection();
        //retrieve the value of the manufacturer from the pres layer
        FilteredLaptops.ReportByManufacturer(txtFilter.Text);
        //set the data source to the list of addresses in the collection
        lstLaptopsList.DataSource = FilteredLaptops.LaptopsList;
        //set the name of the primary key
        lstLaptopsList.DataValueField = "LaptopId";
        //set the name of the field to display
        lstLaptopsList.DataTextField = "LaptopModel";
        //bind the data to the list
        lstLaptopsList.DataBind();
    }

    protected void btnFilterRemove_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsLaptopsCollection FilteredLaptops = new clsLaptopsCollection();
        //retrieve the value of the manufacturer from the pres layer
        FilteredLaptops.ReportByManufacturer("");
        //clear the filter from the interface
        txtFilter.Text = "";
        //set the data source to the list of addresses in the collection
        lstLaptopsList.DataSource = FilteredLaptops.LaptopsList;
        //set the name of the primary key
        lstLaptopsList.DataValueField = "LaptopId";
        //set the name of the field to display
        lstLaptopsList.DataTextField = "LaptopModel";
        //bind the data to the list
        lstLaptopsList.DataBind();
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        //reset the logged in user
        Session["User"] = new clsLaptopsUser();
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}