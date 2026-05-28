using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProductLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the customer user class
        clsProductUser AnUser = new clsProductUser();
        //create the variabls to store the username and password
        string Username = txtUsername.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUsername.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record of the user that matches the username and password entered
        Found = AnUser.FindUser(Username, Password);
        //if username and/or password are empty
        if (txtUsername.Text == "")
        {
            //record the error
            lblError.Text = "Please enter a username";
        }
        else if (txtPassword.Text == "")
        {
            //record the error
            lblError.Text = "Please enter a password";
        }
        //if the user is found
        else if (Found == true)
        {
            //redirect to the customer page
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            //record the error
            lblError.Text = "Incorrect username or password. Please try again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}