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
        //varable to store any error messages
        String Error = "";
        //validate the data
        Error = AnProduct.Valid(txtProductName.Text, txtProductAmount.Text, txtStockArrivalDate.Text, txtSupplierID.Text);
        if (Error == "")
        {
            //store the data in the session object
            AnProduct.ProductID = Convert.ToInt32(txtProductID.Text);
            AnProduct.ProductName = txtProductName.Text;
            AnProduct.ProductAmount = Convert.ToInt32(txtProductAmount.Text);
            AnProduct.StockArrivalDate = Convert.ToDateTime(txtStockArrivalDate.Text);
            AnProduct.SupplierID = Convert.ToInt32(txtSupplierID.Text);
            AnProduct.InStock = InStock.Checked;
            //store as a session
            Session["AnProduct"] = AnProduct;
            //redirect to the viewer page
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct AnProduct = new clsProduct();

        Int32 ProductID;

        Boolean Found = false;

        ProductID = Convert.ToInt32(txtProductID.Text);

        Found = AnProduct.Find(ProductID);

        if (Found)
        {
            txtProductName.Text = AnProduct.ProductName;
            txtProductAmount.Text = AnProduct.ProductAmount.ToString();
            txtStockArrivalDate.Text = AnProduct.StockArrivalDate.ToString();
            txtSupplierID.Text = AnProduct.SupplierID.ToString();
            InStock.Checked = AnProduct.InStock;
        }

        }
}