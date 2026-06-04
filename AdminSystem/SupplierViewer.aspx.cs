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
        clsSupplier aSupplier = new clsSupplier();
        aSupplier = (clsSupplier)Session["aSupplier"];
        Response.Write("Supplier ID: " + aSupplier.SupplierID + "<br />");
        Response.Write("Supplier Name: " + aSupplier.SupplierName + "<br />");
        Response.Write("Address: " + aSupplier.SupplierAddress + "<br />");
        Response.Write("Contact Email: " + aSupplier.SupplierEmail + "<br />");
        Response.Write("Contact Phone: " + aSupplier.SupplierPhoneNumber + "<br />");
        Response.Write("Created Date: " + aSupplier.SupplierCreatedDate + "<br />");
        Response.Write("Is Active: " + aSupplier.SupplierActive + "<br />");

    }
}