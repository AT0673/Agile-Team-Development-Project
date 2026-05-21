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
        int SupplierID = Convert.ToInt32(txtSupplierID.Text);
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
            aSupplier.SupplierID = SupplierID;
            aSupplier.SupplierName = SupplierName;
            aSupplier.SupplierEmail = SupplierEmail;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierAddress = SupplierAddress;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierCreatedDate = Convert.ToDateTime(SupplierCreatedDate);
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
        SupplierID = Convert.ToInt32(this.txtSupplierID.Text);
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
        int SupplierID = Convert.ToInt32(Session["SupplierID"]);
        clsSupplierCollection SupplierList = new clsSupplierCollection();
        SupplierList.ThisSupplier.Find(SupplierID);
        txtSupplierName.Text = SupplierList.ThisSupplier.SupplierName;
        txtSupplierEmail.Text = SupplierList.ThisSupplier.SupplierEmail;
        txtSupplierAddress.Text = SupplierList.ThisSupplier.SupplierAddress;
        txtSupplierPhoneNumber.Text = SupplierList.ThisSupplier.SupplierPhoneNumber;
        txtSupplierCreatedDate.Text = SupplierList.ThisSupplier.SupplierCreatedDate.ToString();
        chkSupplierActive.Checked = SupplierList.ThisSupplier.SupplierActive;
    }
}