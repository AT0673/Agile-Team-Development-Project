using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            if (ProductID != -1)
            {
                DisplayProduct();
            }
        }
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
            AnProduct.ProductID = ProductID;
            AnProduct.ProductName = txtProductName.Text;
            AnProduct.ProductAmount = Convert.ToInt32(txtProductAmount.Text);
            AnProduct.StockArrivalDate = Convert.ToDateTime(txtStockArrivalDate.Text);
            AnProduct.SupplierID = Convert.ToInt32(txtSupplierID.Text);
            AnProduct.InStock = InStock.Checked;
            clsProductCollection ProductList = new clsProductCollection();

            if (ProductID == -1)
            {
                ProductList.ThisProduct = AnProduct;
                ProductList.Add();
            }
            else
            {
                ProductList.ThisProduct.Find(ProductID);
                ProductList.ThisProduct = AnProduct;
                ProductList.Update();
            }
            Response.Redirect("StockList.aspx");
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

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    void DisplayProduct()
    {
        clsProductCollection ProductList = new clsProductCollection();
        ProductList.ThisProduct.Find(ProductID);
        txtProductName.Text = ProductList.ThisProduct.ProductName;
        txtProductAmount.Text = ProductList.ThisProduct.ProductAmount.ToString();
        txtStockArrivalDate.Text = ProductList.ThisProduct.StockArrivalDate.ToString();
        txtSupplierID.Text = ProductList.ThisProduct.SupplierID.ToString();
        InStock.Checked = ProductList.ThisProduct.InStock;
    }
}