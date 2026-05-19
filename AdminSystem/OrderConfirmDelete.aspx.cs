using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the order ID
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //display the order summary for this record
            DisplayOrder();
        }
    }

    void DisplayOrder()
    {
        //Create a new instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to delete
        Boolean Found = Orders.ThisOrder.Find(OrderID);

        if (Found)
        {
            lblOrderSummary.Text = Orders.ThisOrder.OrderSummary;
        }
        else
        {
            lblOrderSummary.Text = "The selected order could not be found.";
            btnYes.Enabled = false;
        }
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //find the record to delete
        Orders.ThisOrder.Find(OrderID);
        //delete the record
        Orders.Delete();
        //redirect back to the main page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirtect back to the main page
        Response.Redirect("OrderList.aspx");
    }
}
