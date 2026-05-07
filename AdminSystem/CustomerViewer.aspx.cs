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
        //create a new instance of clsCustomer
        clsCustomer aCustomer = new clsCustomer();
        //get the data from the session object
        aCustomer = (clsCustomer)Session["aCustomer"];
        //display the customer ID for this entry
        Response.Write(aCustomer.CustomerID);
    }
}