using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //capture the customer ID
        aCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Session["aCustomer"] = aCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = ACustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the labels
            lblCustomerFirstName.Text = ACustomer.CustomerFirstName;
            lblCustomerLastName.Text = ACustomer.CustomerLastName;
            lblCustomerEmail.Text = ACustomer.CustomerEmail;
            lblCustomerPassword.Text = ACustomer.CustomerPassword;
            lblCustomerPhone.Text = ACustomer.CustomerPhone;
            lblCustomerAddress.Text = ACustomer.CustomerAddress;
            lblDateAdded.Text = ACustomer.DateAdded.ToString();
            lblActive.Text = ACustomer.Active.ToString();
        }
        else
        {
            //report an error
            lblError.Text = "Record not found";
        }
    }
}