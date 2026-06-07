using System;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // only load the list the first time the page opens
        // (postbacks wipes out the user's selection)
        if (!IsPostBack)
        {
            DisplaySuppliers();
        }
    }

    // loads all suppliers into the listbox
    void DisplaySuppliers()
    {
        clsSupplierCollection Suppliers = new clsSupplierCollection();

        // hook the listbox up to the supplier list
        lstSupplierList.DataSource = Suppliers.Supplierlist;
        lstSupplierList.DataValueField = "SupplierID";   // the hidden value
        lstSupplierList.DataTextField = "SupplierName";  // what the user sees
        lstSupplierList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // -1 tells data entry page we're adding a new record
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // make sure the user actually selected something
        if (lstSupplierList.SelectedIndex != -1)
        {
            // grab the ID of the selected supplier
            int SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);

            // store it so the next page knows which record to edit
            Session["SupplierID"] = SupplierID;

            Response.Redirect("SupplierDataEntry.aspx");
        }
        else
        {
            // nothing selected → show an error
            lblError.Text = "please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // same idea as edit, but redirect to the delete confirmation page
        if (lstSupplierList.SelectedIndex != -1)
        {
            int SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        // create a new collection and filter it by the text entered
        clsSupplierCollection aSupplier = new clsSupplierCollection();
        aSupplier.ReportBySupplierName(txtFilterSupplierName.Text);

        // update the listbox with the filtered results
        lstSupplierList.DataSource = aSupplier.Supplierlist;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        // reset the filter and reload all suppliers
        clsSupplierCollection aSupplier = new clsSupplierCollection();
        aSupplier.ReportBySupplierName("");

        txtFilterSupplierName.Text = "";

        lstSupplierList.DataSource = aSupplier.Supplierlist;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "SupplierName";
        lstSupplierList.DataBind();
    }
}
