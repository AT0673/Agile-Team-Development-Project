using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // store the id of the supplier we're deleting
    Int32 SupplierID;

    protected void Page_Load(object sender, EventArgs e)
    {
        // pull the id out of session (set on the list page)
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        // create the collection so we can access the delete method
        clsSupplierCollection SupplierList = new clsSupplierCollection();

        // load the supplier we want to delete
        SupplierList.ThisSupplier.Find(SupplierID);

        // delete it from the database
        SupplierList.Delete();

        // go back to the list page
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        // user changed their mind so go back to the supplier list
        Response.Redirect("SupplierList.aspx");
    }
}
