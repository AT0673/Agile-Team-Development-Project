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
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //get the data from the session object
        if (Session["AnOrder"] != null)
        {
            AnOrder = (clsOrder)Session["AnOrder"];
            //display the order details
            Response.Write("Order ID: " + AnOrder.OrderID + "<br />");
            Response.Write("Customer ID: " + AnOrder.CustomerID + "<br />");
            Response.Write("Order Date: " + AnOrder.OrderDate + "<br />");
            Response.Write("Total Price: " + AnOrder.TotalPrice + "<br />");
            Response.Write("Status: " + AnOrder.OrderStatus + "<br />");
            Response.Write("Product ID: " + AnOrder.ProductID + "<br />");
            Response.Write("Is Guest Order: " + AnOrder.isGuestOrder + "<br />");
        }
        else
        {
            //Redirect to the data entry page if there is no order in the session
            Response.Redirect("OrderEntry.aspx");
        }
    }
}
