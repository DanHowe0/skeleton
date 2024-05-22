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
            //capture the model value
            newLaptop.LaptopModel = txtLaptopModel.Text;
            //capture the manufacturer value
            newLaptop.LaptopManufacturer = txtLaptopManufacturer.Text;
            //capture the quantity value
            newLaptop.LaptopQuantity = Convert.ToInt32(txtLaptopQuantity.Text);
            //capture the price value
            newLaptop.LaptopPrice = Convert.ToInt32(txtLaptopPrice.Text);
            //capture the reorder value
            newLaptop.LaptopReorder = Convert.ToBoolean(chkLaptopReorder.Text);
            //capture the reorder date value
            newLaptop.LaptopReorderDate = Convert.ToDateTime(txtLaptopReorderDate.Text);
            // add the data to a session for later
            Session["aLaptop"] = newLaptop;

            //redirect to the viewer page
            Response.Redirect("LaptopsViewer.aspx");
        } else
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
}