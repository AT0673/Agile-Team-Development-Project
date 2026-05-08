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
        clsProduct AnProduct = new clsProduct();

        AnProduct = (clsProduct)Session["AnProduct"];

        Response.Write("Product ID: " + AnProduct.ProductID + "<br />");
        Response.Write("Product Name: " + AnProduct.ProductName + "<br />");
        Response.Write("Product Amount: " + AnProduct.ProductAmount + "<br />");
        Response.Write("Stock Arrival Date: " + AnProduct.StockArrivalDate + "<br />");
        Response.Write("Supplier ID: " + AnProduct.SupplierID + "<br />");
        Response.Write("In Stock: " + AnProduct.InStock + "<br />");

    }
}