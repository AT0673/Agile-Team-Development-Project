using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();

        AnProduct.ProductID = Convert.ToInt32(txtProductID.Text);
        AnProduct.ProductName = txtProductName.Text;
        AnProduct.ProductAmount -= Convert.ToInt32(txtProductAmount.Text);
        AnProduct.StockArrivalDate = Convert.ToDateTime(txtStockArrivalDate.Text);
        AnProduct.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        AnProduct.InStock = InStock.Checked;

        Session["AnProduct"] = AnProduct;

        Response.Redirect("StockViewer.aspx");
    }
}