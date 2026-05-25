using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderUser AnUser = Session["AnUser"] as clsOrderUser;

        if (AnUser != null)
        {
            lblLoggedInUser.Text = "Logged in as: " + AnUser.Username;
        }
        else if (Session["OrderUsername"] != null)
        {
            lblLoggedInUser.Text = "Logged in as: " + Convert.ToString(Session["OrderUsername"]);
        }
        else
        {
            lblLoggedInUser.Text = "Logged in as: unknown user";
        }

        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //load customer choices for the filter dropdown
            LoadCustomerFilter();
            //update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderSummary";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into the session to indicate this is a new record
        Session["OrderID"] = -1;
        //Redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of the record to edit
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to delete
        Int32 OrderID;
        //if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            //store the data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the delete page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //clear any previous error message
        lblError.Text = "";
        //make sure only one filter is used at a time
        Int32 FilterCount = 0;

        if (ddlStatusFilter.SelectedValue.Length != 0)
        {
            FilterCount++;
        }

        if (ddlCustomerFilter.SelectedValue.Length != 0)
        {
            FilterCount++;
        }

        if (ddlGuestFilter.SelectedValue.Length != 0)
        {
            FilterCount++;
        }

        if (FilterCount > 1)
        {
            lblError.Text = "Please use one filter at a time";
            return;
        }

        //retrieve the order status to filter by
        if (ddlStatusFilter.SelectedValue.Length != 0)
        {
            Orders.ReportByOrderStatus(ddlStatusFilter.SelectedValue);
        }

        //retrieve the customer id to filter by
        if (ddlCustomerFilter.SelectedValue.Length != 0)
        {
            Int32 CustomerID;

            if (Int32.TryParse(ddlCustomerFilter.SelectedValue, out CustomerID))
            {
                Orders.ReportByCustomerID(CustomerID);
            }
            else
            {
                lblError.Text = "Please enter a valid Customer ID";
                return;
            }
        }

        //retrieve the guest order filter
        if (ddlGuestFilter.SelectedValue.Length != 0)
        {
            Boolean isGuestOrder = Convert.ToBoolean(ddlGuestFilter.SelectedValue);
            Orders.ReportByGuestOrder(isGuestOrder);
        }
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderSummary";
        //bind the data to the list
        lstOrderList.DataBind();

    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the order collection
        clsOrderCollection Orders = new clsOrderCollection();
        //clear any previous error message
        lblError.Text = "";
        //set an empty string to the order status to filter by
        Orders.ReportByOrderStatus("");
        //clear any existing filter to tidy up the interface
        ddlStatusFilter.SelectedValue = "";
        ddlCustomerFilter.SelectedValue = "";
        ddlGuestFilter.SelectedValue = "";
        //set the data source to the list of orders in the collection
        lstOrderList.DataSource = Orders.OrderList;
        //set the name of the primary key
        lstOrderList.DataValueField = "OrderID";
        //set the data field to display
        lstOrderList.DataTextField = "OrderSummary";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    void LoadCustomerFilter()
    {
        //populate customer filter from tblCustomer so admins do not need to type ids
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblCustomer_SelectAll");

        ddlCustomerFilter.Items.Clear();
        ddlCustomerFilter.Items.Add(new ListItem("All Customers", ""));

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

            ddlCustomerFilter.Items.Add(new ListItem(DisplayText, CustomerID));
        }
    }

    string GetColumnText(DataRow Row, string ColumnName)
    {
        if (Row.Table.Columns.Contains(ColumnName) && Row[ColumnName] != DBNull.Value)
        {
            return Convert.ToString(Row[ColumnName]);
        }

        return "";
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        ClearOrderLoginSession();
        Response.Redirect("TeamMainMenu.aspx");
    }

    void ClearOrderLoginSession()
    {
        Session.Remove("AnUser");
        Session.Remove("OrderUserID");
        Session.Remove("OrderUsername");
        Session.Remove("OrderDepartment");
    }
}
