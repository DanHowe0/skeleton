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
        clsLaptops aLaptop = new clsLaptops();
        aLaptop = (clsLaptops)Session["newLaptop"];
        Response.Write(aLaptop.Model + "<br>");
        Response.Write(aLaptop.Manufacturer + "<br>");
        Response.Write(aLaptop.Quantity + "<br>");
        Response.Write("£"+aLaptop.Price + "<br>");
        Response.Write(aLaptop.Reorder + "<br>");
        Response.Write(aLaptop.ReorderDate + "<br>");
    }
}