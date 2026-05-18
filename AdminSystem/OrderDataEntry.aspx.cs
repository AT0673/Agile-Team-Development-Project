using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the order to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        //create an instance of the order collection
        clsOrderCollection OrderList = new clsOrderCollection();
        //find the record to update
        OrderList.ThisOrder.Find(OrderID);
        //display the data for this record
        txtOrderID.Text = OrderList.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = OrderList.ThisOrder.CustomerID.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString("yyyy-MM-dd");
        txtTotalPrice.Text = OrderList.ThisOrder.TotalPrice.ToString();
        txtStatus.Text = OrderList.ThisOrder.OrderStatus;
        chkIsGuestOrder.Checked = OrderList.ThisOrder.isGuestOrder;
        txtProductID.Text = OrderList.ThisOrder.ProductID.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //variable to store any error messages
        String Error = "";
        //validate the data first (Valid accepts strings)
        Error = AnOrder.Valid(txtCustomerID.Text, txtOrderDate.Text, txtTotalPrice.Text,
                                txtStatus.Text, chkIsGuestOrder.Checked.ToString(), txtProductID.Text);
        if (Error != "")
        {
            //display the validation error(s)
            lblError.Text = Error;
            return;
        }

        // At this point validation passed, so perform safe conversions and assign
        int tmpInt;
        decimal tmpDec;
        DateTime tmpDate;
        bool tmpBool = chkIsGuestOrder.Checked;

        // Try to convert and show a clear message if conversion fails (shouldn't for valid input)
        if (!int.TryParse(txtOrderID.Text, out tmpInt))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.OrderID = tmpInt;

        if (!int.TryParse(txtCustomerID.Text, out tmpInt))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.CustomerID = tmpInt;

        if (!DateTime.TryParse(txtOrderDate.Text, out tmpDate))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.OrderDate = tmpDate;

        if (!decimal.TryParse(txtTotalPrice.Text, out tmpDec))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.TotalPrice = tmpDec;

        AnOrder.OrderStatus = txtStatus.Text;

        if (!int.TryParse(txtProductID.Text, out tmpInt))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.ProductID = tmpInt;

        AnOrder.isGuestOrder = tmpBool;

        //if there are no errors, store the order data in the session object
        Session["AnOrder"] = AnOrder;

        // Assign the OrderID from session BEFORE the Add/Update branch
        AnOrder.OrderID = Convert.ToInt32(Session["OrderID"]);

        // Create an instance of the order collection
        clsOrderCollection OrderList = new clsOrderCollection();

        if (Convert.ToInt32(Session["OrderID"]) == -1)
        {
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
        }
        else
        {
            OrderList.ThisOrder.Find(AnOrder.OrderID);
            OrderList.ThisOrder = AnOrder;
            OrderList.Update();
        }

        Response.Redirect("OrderList.aspx");

        //redirect to the list page
        Response.Redirect("OrderList.aspx");
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
        if (Found)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            txtStatus.Text = AnOrder.OrderStatus;
            txtProductID.Text = AnOrder.ProductID.ToString();
            chkIsGuestOrder.Checked = AnOrder.isGuestOrder;
        }
    }
}
