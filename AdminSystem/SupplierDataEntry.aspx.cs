using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsSupplier aSupplier = new clsSupplier();
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;   
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierPhoneNumber = txtSupplierPhoneNumber.Text;
        DateTime SupplierCreatedDate = Convert.ToDateTime(txtSupplierCreatedDate.Text);
        string Active = chkSupplierActive.Checked.ToString();
        string Error = "";
        Error = aSupplier.Valid(SupplierName, SupplierEmail, SupplierAddress, SupplierPhoneNumber, SupplierCreatedDate);
        if (Error == "")
        {
            aSupplier.SupplierName = SupplierName;
            aSupplier.SupplierEmail = SupplierEmail;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierAddress = SupplierAddress;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierCreatedDate = Convert.ToDateTime(SupplierCreatedDate);
            Session["aSupplier"] = aSupplier;
            Response.Redirect("SupplierViewer.aspx");

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
        SupplierID = Convert.ToInt32(this.txtSupplierID.Text);
        Found = aSupplier.Find(SupplierID);
        if (Found == true)
        {
            txtSupplierName.Text = aSupplier.SupplierName;
            txtSupplierEmail.Text = aSupplier.SupplierEmail;
            txtSupplierAddress.Text = aSupplier.SupplierAddress;
            txtSupplierPhoneNumber.Text = aSupplier.SupplierPhoneNumber;
            txtSupplierCreatedDate.Text = aSupplier.SupplierCreatedDate.ToString();
        }
    }
}