using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Populate fields when the page is first loaded for editing an existing record
        if (!IsPostBack)
        {
            DisplaySupplier();
        }
    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier aSupplier = new clsSupplier();
        int SupplierID = -1;
        // safely parse SupplierID, default to -1 when blank/invalid
        if (!int.TryParse(txtSupplierID.Text, out SupplierID))
        {
            SupplierID = -1;
        }
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierPhoneNumber = txtSupplierPhoneNumber.Text;
        // safely parse created date; if invalid leave as DateTime.MinValue so validation can catch it
        DateTime SupplierCreatedDate;
        if (!DateTime.TryParse(txtSupplierCreatedDate.Text, out SupplierCreatedDate))
        {
            SupplierCreatedDate = DateTime.MinValue;
        }
        string Active = chkSupplierActive.Checked.ToString();
        string Error = "";
        Error = aSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierPhoneNumber, SupplierCreatedDate);
        if (Error == "")
        {
            aSupplier.SupplierID = SupplierID;
            aSupplier.SupplierName = SupplierName;
            aSupplier.SupplierEmail = SupplierEmail;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierAddress = SupplierAddress;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierCreatedDate = SupplierCreatedDate;
            aSupplier.SupplierActive = chkSupplierActive.Checked;
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Update();
            }
            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier aSupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        // safely parse SupplierID entered by user
        if (!Int32.TryParse(this.txtSupplierID.Text, out SupplierID))
        {
            lblError.Text = "Please enter a valid Supplier ID to find";
            return;
        }
        Found = aSupplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = aSupplier.SupplierName;
            txtSupplierEmail.Text = aSupplier.SupplierEmail;
            txtSupplierAddress.Text = aSupplier.SupplierAddress;
            txtSupplierPhoneNumber.Text = aSupplier.SupplierPhoneNumber;
            txtSupplierCreatedDate.Text = aSupplier.SupplierCreatedDate.ToString();
            chkSupplierActive.Checked = aSupplier.SupplierActive;
        }
    }

    protected void DisplaySupplier()
    {
        int SupplierID = -1;
        if (Session["SupplierID"] != null)
        {
            Int32.TryParse(Session["SupplierID"].ToString(), out SupplierID);
        }
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        if (SupplierID != -1)
        {
            SupplierList.ThisSupplier.Find(SupplierID);
            // populate the hidden id field so btnOK knows this is an update
            txtSupplierID.Text = SupplierID.ToString();
            txtSupplierName.Text = SupplierList.ThisSupplier.SupplierName;
            txtSupplierEmail.Text = SupplierList.ThisSupplier.SupplierEmail;
            txtSupplierAddress.Text = SupplierList.ThisSupplier.SupplierAddress;
            txtSupplierPhoneNumber.Text = SupplierList.ThisSupplier.SupplierPhoneNumber;
            txtSupplierCreatedDate.Text = SupplierList.ThisSupplier.SupplierCreatedDate.ToString();
            chkSupplierActive.Checked = SupplierList.ThisSupplier.SupplierActive;
            return;
        }
        // If SupplierID is -1 (new record) clear the fields
        txtSupplierName.Text = string.Empty;
        txtSupplierEmail.Text = string.Empty;
        txtSupplierAddress.Text = string.Empty;
        txtSupplierPhoneNumber.Text = string.Empty;
        txtSupplierCreatedDate.Text = string.Empty;
        chkSupplierActive.Checked = false;

    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }
}