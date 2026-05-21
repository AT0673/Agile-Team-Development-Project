using System;
using System.IO;

namespace ClassLibrary
{
    public class clsCustomerUser
    {
        //private data member for the user id property
        private Int32 mUserID;
        public int UserID
        {
            get
            {
                //return the private data
                return mUserID;
            }
            set
            {
                //set the private data
                mUserID = value;
            }
        }
        //private data member for the username property
        private string mUsername;
        public string Username
        {
            get
            {
                //return the private data
                return mUsername;
            }
            set
            {
                //set the private data
                mUsername = value;
            }
        }
        //private data member for the password property
        private string mPassword;
        public string Password
        {
            get
            {
                //return the private data
                return mPassword;
            }
            set
            {
                //set the private data
                mPassword = value;
            }
        }
        //private data member for the department property
        private string mDepartment;
        public string Department
        {
            get
            {
                //return the private data
                return mDepartment;
            }
            set
            {
                //set the private data
                mDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the username and password to search for
            DB.AddParameter("@Username", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or none)
            if (DB.Count == 1)
            {
                //copy the data from the databse to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return true to confirm everything worked ok
                return true;
            }
            else
            {
                return false;
            }
        }

        

        
    }
}