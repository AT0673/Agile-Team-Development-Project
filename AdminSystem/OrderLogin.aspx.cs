using System;
using System.Web.UI;
using ClassLibrary;

public partial class OrderLogin : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0)
        {
            lblError.Text = "Please enter a username and password";
            return;
        }

        clsOrderUser AnUser = new clsOrderUser();

        if (AnUser.FindUser(txtUsername.Text, txtPassword.Text))
        {
            Session["OrderUserID"] = AnUser.UserID;
            Session["OrderUsername"] = AnUser.Username;
            Session["OrderDepartment"] = AnUser.Department;
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = "Username or password is incorrect";
        }
    }
}
