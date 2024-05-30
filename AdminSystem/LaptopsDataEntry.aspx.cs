using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 LaptopId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the Laptop to be processed
        LaptopId = Convert.ToInt32(Session["LaptopId"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (LaptopId != -1)
            {
                //display the current data for the record
                DisplayLaptop();
            }
        }

        //set the user
        clsLaptopsUser User = (clsLaptopsUser)Session["User"];
        lblUser.Text = "Logged in as: " + User.UserName;
    }

    void DisplayLaptop()
    {
        //create an instance of the address book
        clsLaptopsCollection Laptops = new clsLaptopsCollection();
        //find the record to update
        Laptops.ThisLaptop.Find(LaptopId);
        //display the data for the record
        txtLaptopID.Text = Laptops.ThisLaptop.LaptopID.ToString();
        txtLaptopModel.Text = Laptops.ThisLaptop.LaptopModel.ToString();
        txtLaptopManufacturer.Text = Laptops.ThisLaptop.LaptopManufacturer.ToString();
        txtLaptopQuantity.Text = Laptops.ThisLaptop.LaptopQuantity.ToString();
        txtLaptopPrice.Text = Laptops.ThisLaptop.LaptopPrice.ToString();
        chkLaptopReorder.Checked = Laptops.ThisLaptop.LaptopReorder;
        txtLaptopReorderDate.Text = Laptops.ThisLaptop.LaptopReorderDate.ToString();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create new laptop instance
        clsLaptops newLaptop = new clsLaptops();
        //capture the model value
        string LaptopModel = txtLaptopModel.Text;
        //capture the manufacturer value
        string LaptopManufacturer = txtLaptopManufacturer.Text;
        //capture the quantity value
        string LaptopQuantity = txtLaptopQuantity.Text;
        //capture the price value
        string LaptopPrice = txtLaptopPrice.Text;
        //capture the reorder value
        string LaptopReorder = chkLaptopReorder.Text;
        //capture the reorder date value
        string LaptopReorderDate = txtLaptopReorderDate.Text;
        //store any error messages
        string Error = "";
        //validate the data
        Error = newLaptop.Valid(LaptopModel, LaptopManufacturer, LaptopQuantity, LaptopPrice, LaptopReorderDate);
        if (Error == "")
        {
            //capture the address id
            newLaptop.LaptopID = LaptopId;
            //capture the model value
            newLaptop.LaptopModel = txtLaptopModel.Text;
            //capture the manufacturer value
            newLaptop.LaptopManufacturer = txtLaptopManufacturer.Text;
            //capture the quantity value
            newLaptop.LaptopQuantity = Convert.ToInt32(txtLaptopQuantity.Text);
            //capture the price value
            newLaptop.LaptopPrice = Convert.ToDouble(txtLaptopPrice.Text);
            //capture the reorder value
            Console.WriteLine(chkLaptopReorder.Text);
            newLaptop.LaptopReorder = chkLaptopReorder.Checked;
            //capture the reorder date value
            newLaptop.LaptopReorderDate = Convert.ToDateTime(txtLaptopReorderDate.Text);
            //create a new instance od the address collection
            clsLaptopsCollection LaptopsList = new clsLaptopsCollection();

            //if this is a new record then add the data
            if (LaptopId == -1)
            {
                //set the ThisAddress property
                LaptopsList.ThisLaptop = newLaptop;
                //add the new record
                LaptopsList.Add();
            } 
            //else it must be an update
            else 
            {
                //find the record to update
                LaptopsList.ThisLaptop.Find(LaptopId);
                //set the ThisAddress property
                LaptopsList.ThisLaptop = newLaptop;
                //update the record
                LaptopsList.Update();
            }

            //redirect to the list page
            Response.Redirect("LaptopsList.aspx");
        } 
        else 
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the laptop class
        clsLaptops aLaptop = new clsLaptops();
        //create a variable to store the primary key
        Int32 LaptopId;
        //create a variable to store the result of a find operation
        Boolean Found = false;
        //get the primary key entered by the user
        LaptopId = Convert.ToInt32(txtLaptopID.Text);
        //find the record
        Found = aLaptop.Find(LaptopId);
        //if found
        if (Found)
        {
            //display the values of the properties in the form
            txtLaptopModel.Text = aLaptop.LaptopModel;
            txtLaptopManufacturer.Text = aLaptop.LaptopManufacturer;
            txtLaptopPrice.Text = aLaptop.LaptopPrice.ToString();
            txtLaptopQuantity.Text = aLaptop.LaptopQuantity.ToString();
            chkLaptopReorder.Checked = aLaptop.LaptopReorder;
            txtLaptopReorderDate.Text = aLaptop.LaptopReorderDate.ToString();

        }
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        //reset the logged in user
        Session["User"] = new clsLaptopsUser();
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LaptopsList.aspx");
    }
}