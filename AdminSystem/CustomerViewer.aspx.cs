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
        Response.Write(Request.QueryString["CustomerID"] + "<br />");
        Response.Write(Request.QueryString["CustomerFirstName"] + "<br />");
        Response.Write(Request.QueryString["CustomerEmail"] + "<br />");
        Response.Write(Request.QueryString["CustomerPassword"] + "<br />");
        Response.Write(Request.QueryString["CustomerAddress"] + "<br />");
        Response.Write(Request.QueryString["CustomerIsActive"] + "<br />");
        Response.Write(Request.QueryString["CustomerDOB"] + "<br />");
        Response.Write(Request.QueryString["DateAdded"] + "<br />");
    }
}