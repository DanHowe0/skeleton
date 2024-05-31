using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LaptopsLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the user class
        clsLaptopsUser AnUser = new clsLaptopsUser();
        //create the variables to store the username and password
        string UserName = Convert.ToString(txtUser.Text);
        string Password = Convert.ToString(txtPass.Text);
        //create a variable to store the result of the find method
        Boolean Found = false;
        //find the record
        Found = AnUser.FindUser(UserName, Password);
        //if username or password is empty
        if (UserName == "")
        {
            //record the error
            lblError.Text = "Enter a Username ";
        } else if (Password == "") {
            //record the error
            lblError.Text = "Enter a Password ";
        }
        //if not part of the department
        else if (Found && AnUser.Department != "Laptops")
        {
            //record the error
            lblError.Text = "You do not have access to this system";
        }
        //if found
        else if (Found && AnUser.Department == "Laptops")
        {
            //add username to the session
            Session["User"] = AnUser;
            //redirect to the list page
            Response.Redirect("LaptopsList.aspx");
        } else if (!Found) {
            //record the error
            lblError.Text = "Login Details incorrect. Try again ;) ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        //reset the logged in user
        Session["User"] = new clsLaptopsUser();
        //redirect to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}