using System;
using System.Collections.Generic;
using System.Data;
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
        if (IsPostBack == false)
        {
            OrderID = Convert.ToInt32(Session["OrderID"]);
            ViewState["OrderID"] = OrderID;
        }
        else
        {
            OrderID = Convert.ToInt32(ViewState["OrderID"]);
        }

        if (IsPostBack == false)
        {
            //load the dropdown lists from their related tables
            LoadCustomers();
            LoadProducts();

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
        SetSelectedCustomer(OrderList.ThisOrder.CustomerID);
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString("yyyy-MM-dd");
        txtTotalPrice.Text = OrderList.ThisOrder.TotalPrice.ToString();
        SetSelectedStatus(OrderList.ThisOrder.OrderStatus);
        chkIsGuestOrder.Checked = OrderList.ThisOrder.isGuestOrder;
        SetSelectedProduct(OrderList.ThisOrder.ProductID);
        ToggleCustomerSelection();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //variable to store any error messages
        String Error = "";
        //validate the data first (Valid accepts strings)
        Error = AnOrder.Valid(ddlCustomer.SelectedValue, txtOrderDate.Text, txtTotalPrice.Text,
                                ddlStatus.SelectedValue, chkIsGuestOrder.Checked.ToString(), ddlProduct.SelectedValue);
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

        AnOrder.OrderID = Convert.ToInt32(ViewState["OrderID"]);

        if (tmpBool)
        {
            AnOrder.CustomerID = 0;
        }
        else if (!int.TryParse(ddlCustomer.SelectedValue, out tmpInt))
        {
            lblError.Text = Error;
            return;
        }
        else
        {
            AnOrder.CustomerID = tmpInt;
        }

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

        AnOrder.OrderStatus = ddlStatus.SelectedValue;

        if (!int.TryParse(ddlProduct.SelectedValue, out tmpInt))
        {
            lblError.Text = Error;
            return;
        }
        AnOrder.ProductID = tmpInt;

        AnOrder.isGuestOrder = tmpBool;

        //if there are no errors, store the order data in the session object
        Session["AnOrder"] = AnOrder;

        // Create an instance of the order collection
        clsOrderCollection OrderList = new clsOrderCollection();

        if (AnOrder.OrderID == -1)
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
        if (!Int32.TryParse(txtOrderID.Text, out OrderID))
        {
            lblError.Text = "Please enter a valid Order ID";
            return;
        }
        //find the record
        Found = AnOrder.Find(OrderID);
        //if found
        if (Found)
        {
            Session["OrderID"] = OrderID;
            ViewState["OrderID"] = OrderID;
            txtOrderID.Text = OrderID.ToString();
            //display the values of the properties in the form
            SetSelectedCustomer(AnOrder.CustomerID);
            txtOrderDate.Text = AnOrder.OrderDate.ToString("yyyy-MM-dd");
            txtTotalPrice.Text = AnOrder.TotalPrice.ToString();
            SetSelectedStatus(AnOrder.OrderStatus);
            SetSelectedProduct(AnOrder.ProductID);
            chkIsGuestOrder.Checked = AnOrder.isGuestOrder;
            ToggleCustomerSelection();
        }
    }

    void LoadCustomers()
    {
        //populate customers from the customer table so the user cannot type an invalid id
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblCustomer_SelectAll");

        ddlCustomer.Items.Clear();
        ddlCustomer.Items.Add(new ListItem("-- Select Customer --", ""));

        foreach (DataRow Row in DB.DataTable.Rows)
        {
            string CustomerID = Convert.ToString(Row["CustomerID"]);
            string CustomerName = GetColumnText(Row, "CustomerFirstName");
            string CustomerEmail = GetColumnText(Row, "CustomerEmail");
            string DisplayText = CustomerID + " - " + CustomerName;

            if (CustomerEmail.Length != 0)
            {
                DisplayText = DisplayText + " (" + CustomerEmail + ")";
            }

            ddlCustomer.Items.Add(new ListItem(DisplayText, CustomerID));
        }
    }

    void LoadProducts()
    {
        //populate products from the product table so the user cannot type an invalid id
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblProduct_SelectAll");

        ddlProduct.Items.Clear();
        ddlProduct.Items.Add(new ListItem("-- Select Product --", ""));

        foreach (DataRow Row in DB.DataTable.Rows)
        {
            string ProductID = Convert.ToString(Row["ProductID"]);
            string ProductName = GetColumnText(Row, "ProductName");
            string DisplayText = ProductID + " - " + ProductName;

            ddlProduct.Items.Add(new ListItem(DisplayText, ProductID));
        }
    }

    string GetColumnText(DataRow Row, string ColumnName)
    {
        //read optional display columns safely in case another team member changes the select list
        if (Row.Table.Columns.Contains(ColumnName) && Row[ColumnName] != DBNull.Value)
        {
            return Convert.ToString(Row[ColumnName]);
        }

        return "";
    }

    void SetSelectedCustomer(Int32 CustomerID)
    {
        ListItem CustomerItem = ddlCustomer.Items.FindByValue(CustomerID.ToString());

        if (CustomerItem != null)
        {
            ddlCustomer.SelectedValue = CustomerID.ToString();
        }
        else
        {
            ddlCustomer.SelectedValue = "";
        }
    }

    void ToggleCustomerSelection()
    {
        if (chkIsGuestOrder.Checked)
        {
            ddlCustomer.SelectedValue = "";
            ddlCustomer.Enabled = false;
        }
        else
        {
            ddlCustomer.Enabled = true;
        }
    }

    void SetSelectedProduct(Int32 ProductID)
    {
        ListItem ProductItem = ddlProduct.Items.FindByValue(ProductID.ToString());

        if (ProductItem != null)
        {
            ddlProduct.SelectedValue = ProductID.ToString();
        }
        else
        {
            ddlProduct.SelectedValue = "";
        }
    }

    void SetSelectedStatus(string OrderStatus)
    {
        //select the order status safely in case old data contains a removed status
        ListItem StatusItem = ddlStatus.Items.FindByValue(OrderStatus);

        if (StatusItem != null)
        {
            ddlStatus.SelectedValue = OrderStatus;
        }
        else
        {
            ddlStatus.SelectedValue = "Pending";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect to the list page without saving
        Response.Redirect("OrderList.aspx");
    }

    protected void chkIsGuestOrder_CheckedChanged(object sender, EventArgs e)
    {
        ToggleCustomerSelection();
    }
}
