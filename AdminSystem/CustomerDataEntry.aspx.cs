using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

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
}