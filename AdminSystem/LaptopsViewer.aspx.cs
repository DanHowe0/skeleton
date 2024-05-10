using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new laptop instance
        clsLaptops aLaptop = new clsLaptops();

        //retrieve data from the session
        aLaptop = (clsLaptops)Session["newLaptop"];

        //write out all the data
        Response.Write(aLaptop.LaptopModel + "<br>");
        Response.Write(aLaptop.LaptopManufacturer + "<br>");
        Response.Write(aLaptop.LaptopQuantity + "<br>");
        Response.Write("£"+aLaptop.LaptopPrice + "<br>");
        Response.Write(aLaptop.LaptopReorder + "<br>");
        Response.Write(aLaptop.LaptopReorderDate + "<br>");
    }
}