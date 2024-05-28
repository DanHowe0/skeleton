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
        lstLaptopsList.DataTextField = "LaptopManufacturer";
        //bind the data to the list
        lstLaptopsList.DataBind();
    }
}