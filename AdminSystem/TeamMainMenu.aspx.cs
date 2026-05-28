using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }

    protected void btnCustomers_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnSuppliers_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierLogin.aspx");
    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        Response.Redirect("ProductLogin.aspx");
    }

    protected void btnOrders_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLogin.aspx");
    }
}
