using System;
using ClassLibrary;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mUserID;
        private String mUsername;
        private String mPassword;
        private String mDepartment;

        public string Username
        {
            get { return mUsername; }
            set { mUsername = value; }
        }

        public int UserID
        {
            get {  return mUserID; }
            set { mUserID = value; }
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

        public bool FindUser(string username, string password)
        {
            //Create an instance
            clsDataConnection DB = new clsDataConnection();
            //add the parameters using lowercase so it uses the passed arguments
            DB.AddParameter("@Username", username);
            DB.AddParameter ("@Password", password);
            //Excecute the stored procedure
            DB.Execute("sproc_tblUsers_FindUsernamePW");
            //if a record exists (there should be one or none)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data memebers
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //Return true if confirmed
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}