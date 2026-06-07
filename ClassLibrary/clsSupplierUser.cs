using System;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        // private fields 
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;

        // public properties

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        public string Username
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public string Department
        {
            get { return mDepartment; }
            set { mDepartment = value; }
        }

        // find a user by username + password
        // if found, load the user details into this object
        public bool FindUser(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();

            // pass login details into the stored procedure
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);

            // run the query
            DB.Execute("sproc_tblUsers_FindUserNamePW");

            // if exactly one matching user exists, map the data
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }

            // no match found
            return false;
        }
    }
}
