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

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsSupplierUser AnUser = new clsSupplierUser();
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;

        // validate input first
        if (String.IsNullOrWhiteSpace(Username))
        {
            lblError.Text = "Please enter a username";

        }
        else if (String.IsNullOrWhiteSpace(Password))
        {
            lblError.Text = "Please enter a password";
        }
        else
        {
            // attempt to find the user
            Found = AnUser.FindUser(Username, Password);
            if (Found)
            {
                // ensure SupplierList can read the session value
                Session["SupplierID"] = -1;
                Response.Redirect("SupplierList.aspx");
            }
            else
            {
                lblError.Text = "Incorrect username or password, try again";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}