using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaffUser AUser = Session["AnUser"] as clsStaffUser;

        if (AUser != null)
        {
            //display the username
            Response.Write("Logged in as: " + AUser.Username);
        }

        if (IsPostBack == false)
        {
            //display all staff when the page loads
            DisplayStaff();
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 in the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to edit
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection aStaff = new clsStaffCollection();
        //retrieve the value of first name from presentation layer
        aStaff.ReportByStaffLastName(txtEnterLastName.Text);
        //set the data source to the list of customers in the collection
        lstStaffList.DataSource = aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "StaffLastName";
        //bind the data to the list
        lstStaffList.DataBind();
    }   

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection
        clsStaffCollection aStaff = new clsStaffCollection();
        //retrieve all the data from the database
        aStaff.ReportByStaffLastName("");
        //clear any existing filter to tidy up the interface
        txtEnterLastName.Text = "";
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = aStaff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "StaffLastName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        //clear the session
        Session.Clear();
        //redirect to the login page
        Response.Redirect("TeamMainMenu.aspx");
    }

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source to the list of customers in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "StaffLastName";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}