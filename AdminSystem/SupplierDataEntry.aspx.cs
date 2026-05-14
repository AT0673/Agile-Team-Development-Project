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
        string SupplierPhoneNumber = txtSupplierPhoneNumber.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierCreatedDate = txtSupplierCreatedDate.Text;
        string Active = chkSupplierActive.Checked.ToString();
        string Error = "";
        Error = aSupplier.Valid(SupplierName, SupplierPhoneNumber, SupplierAddress, SupplierEmail, SupplierCreatedDate);
        if (Error == "")
        {
            aSupplier.SupplierName = SupplierName;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierAddress = SupplierAddress;
            aSupplier.SupplierEmail = SupplierEmail;
            aSupplier.SupplierCreatedDate = Convert.ToDateTime(SupplierCreatedDate);
            Session["aSupplier"] = aSupplier;
            Response.Redirect("SupplierViewer.aspx");

        }
        else {
            lblError.Text = Error;
        }




            Session["aSupplier"] = aSupplier;
        //navigate to view page
        Response.Redirect("SupplierViewer.aspx");
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
            txtSupplierPhoneNumber.Text = aSupplier.SupplierPhoneNumber;
            txtSupplierAddress.Text = aSupplier.SupplierAddress;
            txtSupplierEmail.Text = aSupplier.SupplierEmail;
            txtSupplierCreatedDate.Text = aSupplier.SupplierCreatedDate.ToString();
        }
    }
}