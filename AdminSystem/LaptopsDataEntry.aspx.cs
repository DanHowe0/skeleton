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
        clsLaptops newLaptop = new clsLaptops();
        newLaptop.Model = txtLaptopModel.Text;
        newLaptop.Manufacturer = txtLaptopManufacturer.Text;
        newLaptop.Quantity = Convert.ToInt32(txtLaptopQuantity.Text);
        newLaptop.Price = Convert.ToDouble(txtLaptopPrice.Text);
        newLaptop.Reorder = chkLaptopReorder.Checked;
        newLaptop.ReorderDate = Convert.ToDateTime(txtLaptopReorderDate.Text);

        Session["newLaptop"] = newLaptop;

        Response.Redirect("LaptopsViewer.aspx");
    }
}