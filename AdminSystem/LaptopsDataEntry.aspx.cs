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
        //update the model value
        newLaptop.LaptopModel = txtLaptopModel.Text;
        //update the manufacturer value
        newLaptop.LaptopManufacturer = txtLaptopManufacturer.Text;
        //update the quantity value
        newLaptop.LaptopQuantity = Convert.ToInt32(txtLaptopQuantity.Text);
        //update the price value
        newLaptop.LaptopPrice = Convert.ToDouble(txtLaptopPrice.Text);
        //update the reorder value
        newLaptop.LaptopReorder = chkLaptopReorder.Checked;
        //update the reorder date value
        newLaptop.LaptopReorderDate = Convert.ToDateTime(txtLaptopReorderDate.Text);

        // add the data to a session for later
        Session["aLaptop"] = newLaptop;

        //redirect to the viewer page
        Response.Redirect("LaptopsViewer.aspx");
    }
}