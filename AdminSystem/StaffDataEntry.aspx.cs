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

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();

        //capture the staff ID
        AStaff.StaffID = Convert.ToInt32(lblStaffID.Text);

        //capture the staff last name
        AStaff.StaffLastName = lblStaffLastName.Text;

        //capture the staff username
        AStaff.StaffUsername = lblStaffUsername.Text;

        //capture the staff password
        AStaff.StaffPassword = lblStaffPassword.Text;

        //capture the staff address
        AStaff.StaffAddress = lblStaffAddress.Text;

        //capture the date added
        AStaff.DateAdded = DateTime.Now.Date;

        //capture the active status
        AStaff.Active = chkActive.Checked;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AStaff.Valid(
            AStaff.StaffLastName,
            AStaff.StaffUsername,
            AStaff.StaffPassword,
            AStaff.StaffAddress,
            AStaff.Active,
            AStaff.DateAdded);

        if (Error == "")
        {
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();

            //if this is a new record i.e. StaffID = -1 then add the data
            if (Convert.ToInt32(Session["StaffID"]) == -1)
            {
                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;

                //add the new record
                StaffList.Add();
            }
            else
            {
                //set the staff ID from the session
                AStaff.StaffID = Convert.ToInt32(Session["StaffID"]);

                //set the ThisStaff property
                StaffList.ThisStaff = AStaff;

                //update the record
                StaffList.Update();
            }

            //redirect back to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }



        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}