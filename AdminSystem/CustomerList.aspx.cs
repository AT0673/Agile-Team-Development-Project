using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CustomerID != -1)
            {
                //display the current data for the record
                DisplayCustomers();
            }
        }   
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record has been selected
        {
            //lblError.Text = "Please select a record to edit from the list";
        }
    }

    void DisplayCustomers()
    {
        //create an instance of the customer collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomerList.DataTextField = "CustomerFirstName";
        //bind the data to the list
        lstCustomerList.DataBind();
    }
}