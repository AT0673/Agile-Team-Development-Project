using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page has been displayed
        if (IsPostBack == false)
        {
            //clear the error message
            lblError.Text = "";
        }
        //create a new instance of clsCustomerUser
        clsCustomerUser AnUser = new clsCustomerUser();
        //get data from the session object and cast it as a clsCustomerUser
        AnUser = (clsCustomerUser)Session["AnUser"];
        
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create an instance of the customer user class
        clsCustomerUser AnUser = new clsCustomerUser();
        //create the variabls to store the username and password
        string Username = txtUserName.Text;
        string Password = txtPassword.Text;
        //create a variable to store the result of the find user operation
        Boolean Found = false;
        //get the username entered by the user
        Username = Convert.ToString(txtUserName.Text);
        //get the password entered by the user
        Password = Convert.ToString(txtPassword.Text);
        //find the record of the user that matches the username and password entered
        Found = AnUser.FindUser(Username, Password);
        //Add a session to capture the username
        Session["AnUser"] = AnUser;
        //if username and/or password are empty
        if (txtUserName.Text == "")
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
            Response.Redirect("CustomerList.aspx");
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