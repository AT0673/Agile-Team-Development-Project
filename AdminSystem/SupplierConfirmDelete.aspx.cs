using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;
public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the supplier collection
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        //find the record to delete
        SupplierList.ThisSupplier.Find(SupplierID);
        //delete the record
        SupplierList.Delete();
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the main page
        Response.Redirect("SupplierList.aspx");
    }
}