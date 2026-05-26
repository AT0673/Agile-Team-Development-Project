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
        int ID = 1;
        Username = Convert.ToString(txtUsername.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(Username, Password);
        if (txtUsername.Text == "")
        {
            lblError.Text = "Please enter a username";

        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Please enter a password";
        }
        else if (Found == true)
        {
            Response.Redirect("SupplierListaspx");
        }
        else
        {
            lblError.Text = "Incorrect username or password, try again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}