using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // create a user object to check login details
        clsSupplierUser AnUser = new clsSupplierUser();

        // grab whatever the user typed into the textboxes
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;

        // is login succesfull?
        bool Found = false;

        // quick input validation before hitting the database
        if (String.IsNullOrWhiteSpace(Username))
        {
            // username box was empty
            lblError.Text = "please enter a username";
        }
        else if (String.IsNullOrWhiteSpace(Password))
        {
            // password box was empty
            lblError.Text = "please enter a password";
        }
        else
        {
            // try to find a matching user in the database
            Found = AnUser.FindUser(Username, Password);

            if (Found)
            {
                // store something in session so the next page loads properly
                // (supplier list uses this value)
                Session["SupplierID"] = -1;

                // send the user to the supplier list page
                Response.Redirect("SupplierList.aspx");
            }
            else
            {
                // login failed and show an error message
                lblError.Text = "incorrect username or password, try again";
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // user clicked cancel which will send them back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}
