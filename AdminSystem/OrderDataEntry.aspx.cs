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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the order number
        AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
        //capture the customer ID
        AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //Capture the order date
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        //Capture the order total
        AnOrder.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
        //Capture the order status
        AnOrder.Status = txtStatus.Text;
        //Capture the product ID
        AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
        //Capture whether this is a guest order
        AnOrder.isGuestOrder = chkIsGuestOrder.Checked;
        //Store the order in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the viewer page
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the order class
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtStatus.Text = AnOrder.Status;
            txtProductID.Text = AnOrder.ProductID.ToString();
            chkIsGuestOrder.Checked = AnOrder.isGuestOrder;
        }
    }
}