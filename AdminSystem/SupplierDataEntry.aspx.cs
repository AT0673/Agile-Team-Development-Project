using ClassLibrary;
using System;
using System.Web.UI;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // only load supplier details the first time the page opens
        // (postbacks would overwrite whatever the user typed)
        if (!IsPostBack)
        {
            DisplaySupplier();
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a supplier object to hold the data
        clsSupplier aSupplier = new clsSupplier();

        // default supplier id (means new record)
        int SupplierID = -1;

        // try to read the supplier id from the textbox
        // if it's blank or invalid, leave it as -1
        if (!int.TryParse(txtSupplierID.Text, out SupplierID))
        {
            SupplierID = -1;
        }

        // grab all the values the user typed in
        string SupplierName = txtSupplierName.Text;
        string SupplierEmail = txtSupplierEmail.Text;
        string SupplierAddress = txtSupplierAddress.Text;
        string SupplierPhoneNumber = txtSupplierPhoneNumber.Text;

        // try to parse the date — if invalid, set it to MinValue so validation catches it
        DateTime SupplierCreatedDate;
        if (!DateTime.TryParse(txtSupplierCreatedDate.Text, out SupplierCreatedDate))
        {
            SupplierCreatedDate = DateTime.MinValue;
        }

        // run validation on the input
        string Error = aSupplier.Valid(
            SupplierName,
            SupplierEmail,
            SupplierAddress,
            SupplierPhoneNumber,
            SupplierCreatedDate
        );

        // if everything is valid, save it
        if (Error == "")
        {
            // copy the values into the supplier object
            aSupplier.SupplierID = SupplierID;
            aSupplier.SupplierName = SupplierName;
            aSupplier.SupplierEmail = SupplierEmail;
            aSupplier.SupplierAddress = SupplierAddress;
            aSupplier.SupplierPhoneNumber = SupplierPhoneNumber;
            aSupplier.SupplierCreatedDate = SupplierCreatedDate;
            aSupplier.SupplierActive = chkSupplierActive.Checked;

            // create the collection so we can add/update the record
            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplierID == -1)
            {
                // new record then add it
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Add();
            }
            else
            {
                // existing record then update it
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = aSupplier;
                SupplierList.Update();
            }

            // go back to the list page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            // show validation errors
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier aSupplier = new clsSupplier();
        int SupplierID;

        // make sure the user typed a valid number
        if (!int.TryParse(txtSupplierID.Text, out SupplierID))
        {
            lblError.Text = "please enter a valid supplier id to find";
            return;
        }

        // try to find the supplier in the database
        bool Found = aSupplier.Find(SupplierID);

        if (Found)
        {
            // fill the fields with the supplier's data
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

        // read the supplier id from session (set by list page)
        if (Session["SupplierID"] != null)
        {
            int.TryParse(Session["SupplierID"].ToString(), out SupplierID);
        }

        clsSupplierCollection SupplierList = new clsSupplierCollection();

        // if SupplierID is not -1, we're editing an existing record
        if (SupplierID != -1)
        {
            SupplierList.ThisSupplier.Find(SupplierID);

            // fill the textboxes with the existing data
            txtSupplierID.Text = SupplierID.ToString();
            txtSupplierName.Text = SupplierList.ThisSupplier.SupplierName;
            txtSupplierEmail.Text = SupplierList.ThisSupplier.SupplierEmail;
            txtSupplierAddress.Text = SupplierList.ThisSupplier.SupplierAddress;
            txtSupplierPhoneNumber.Text = SupplierList.ThisSupplier.SupplierPhoneNumber;
            txtSupplierCreatedDate.Text = SupplierList.ThisSupplier.SupplierCreatedDate.ToString();
            chkSupplierActive.Checked = SupplierList.ThisSupplier.SupplierActive;

            return;
        }

        // if SupplierID is -1, this is a new record so clear everything
        txtSupplierName.Text = "";
        txtSupplierEmail.Text = "";
        txtSupplierAddress.Text = "";
        txtSupplierPhoneNumber.Text = "";
        txtSupplierCreatedDate.Text = "";
        chkSupplierActive.Checked = false;
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        // user clicked cancel → go back to the list page
        Response.Redirect("SupplierList.aspx");
    }
}
