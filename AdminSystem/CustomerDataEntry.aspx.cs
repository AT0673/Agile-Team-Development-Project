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

    void DisplayCustomer()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find the record to update
        Customers.ThisCustomer.Find(Convert.ToInt32(txtCustomerID.Text));
        //display the data for this record
        txtCustomerFirstName.Text = Customers.ThisCustomer.CustomerFirstName;
        txtCustomerEmail.Text = Customers.ThisCustomer.CustomerEmail;
        txtCustomerPassword.Text = Customers.ThisCustomer.CustomerPassword;
        txtCustomerAddress.Text = Customers.ThisCustomer.CustomerAddress;
        calCustomerDOB.SelectedDate = Customers.ThisCustomer.CustomerDOB;
        chkActive.Checked = Customers.ThisCustomer.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //capture the customer ID
        aCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //capture the customer first name
        aCustomer.CustomerFirstName = txtCustomerFirstName.Text;
        //capture the customer email
        aCustomer.CustomerEmail = txtCustomerEmail.Text;
        //capture the customer password
        aCustomer.CustomerPassword = txtCustomerPassword.Text;
        //capture the customer address
        aCustomer.CustomerAddress = txtCustomerAddress.Text;
        //capture the date added
        aCustomer.DateAdded = DateTime.Now.Date;
        //capture the active status
        aCustomer.Active = chkActive.Checked;
        //capture the customer DOB
        aCustomer.CustomerDOB = calCustomerDOB.SelectedDate;
        //variable to store any error messages
        String Error = "";
        //validate the data
        Error = aCustomer.Valid(aCustomer.CustomerID, aCustomer.CustomerFirstName, aCustomer.Active, aCustomer.CustomerEmail, aCustomer.CustomerPassword, aCustomer.CustomerDOB, aCustomer.CustomerAddress, aCustomer.DateAdded);
        if (Error == "")
        {
            //capture the customer ID
            aCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text); //IMPORTANT
            //capture the customer first name
            aCustomer.CustomerFirstName = txtCustomerFirstName.Text;
            //capture the customer email
            aCustomer.CustomerEmail = txtCustomerEmail.Text;
            //capture the customer password
            aCustomer.CustomerPassword = txtCustomerPassword.Text;
            //capture the customer address
            aCustomer.CustomerAddress = txtCustomerAddress.Text;
            //capture the date added
            aCustomer.DateAdded = DateTime.Now.Date;
            //capture the active status
            aCustomer.Active = chkActive.Checked;
            //capture the customer DOB
            aCustomer.CustomerDOB = calCustomerDOB.SelectedDate;
            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //if this is a new record i.e. CustomerID = -1 then add the data
            if (Convert.ToInt32(Session["CustomerID"]) == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = aCustomer;
                //add the new record
                CustomerList.Add();
            }
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(aCustomer.CustomerID);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = aCustomer;
                //update the record
                CustomerList.Update();
            }
            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer aCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = aCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the labels
            lblCustomerFirstName.Text = aCustomer.CustomerFirstName;
            lblCustomerEmail.Text = aCustomer.CustomerEmail;
            lblCustomerPassword.Text = aCustomer.CustomerPassword;
            lblCustomerAddress.Text = aCustomer.CustomerAddress;
            lblDateAdded.Text = aCustomer.DateAdded.ToString();
            lblActive.Text = aCustomer.Active.ToString();
        }
        else
        {
            //report an error
            lblError.Text = "Record not found";
        }
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}