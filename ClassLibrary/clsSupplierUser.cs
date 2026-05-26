using System;

namespace ClassLibrary
{
    public class clsSupplierUser
    {
        private Int32 mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;
        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }
        public string Username
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string username, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", username);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            if (DB.Count == 1)
            {
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}