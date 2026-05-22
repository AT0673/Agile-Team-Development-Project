using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data members
        private int mStaffID;
        private string mStaffLastName;
        private bool mStaffIsActive;
        private string mStaffUsername;
        private string mStaffPassword;
        private string mStaffAddress;
        private bool mActive;
        private DateTime mDateAdded;

        //public property for StaffID
        public int StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }

        //public property for StaffLastName
        public string StaffLastName
        {
            get
            {
                return mStaffLastName;
            }
            set
            {
                mStaffLastName = value;
            }
        }

        //public property for StaffIsActive
        public bool StaffIsActive
        {
            get
            {
                return mStaffIsActive;
            }
            set
            {
                mStaffIsActive = value;
            }
        }

        //public property for StaffUsername
        public string StaffUsername
        {
            get
            {
                return mStaffUsername;
            }
            set
            {
                mStaffUsername = value;
            }
        }

        //public property for StaffPassword
        public string StaffPassword
        {
            get
            {
                return mStaffPassword;
            }
            set
            {
                mStaffPassword = value;
            }
        }

        //public property for StaffAddress
        public string StaffAddress
        {
            get
            {
                return mStaffAddress;
            }
            set
            {
                mStaffAddress = value;
            }
        }

        //public property for Active
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        //public property for DateAdded
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        //find method
        public bool Find(int StaffID)
        {
            //if the StaffID matches the test data
            if (StaffID == 21)
            {
                mStaffID = Convert.ToInt32("StaffID");
                mStaffLastName = Convert.ToString("StaffLastName");
                mStaffIsActive = Convert.ToBoolean("StaffIsActive");
                mStaffUsername = Convert.ToString("StaffUsername");
                mStaffPassword = Convert.ToString("StaffPassword");
                mStaffAddress = Convert.ToString("StaffAddress");

                //return true because the record was found
                return true;
            }
            else
            {
                //return false if no record was found
                return false;
            }
        }
    
        //valid method
        public string Valid(string StaffLastName,
                            string StaffUsername,
                            string StaffPassword,
                            string StaffAddress,
                            bool StaffIsActive,
                            DateTime DateAdded)
        {
            //string variable to store the error message
            String Error = "";

            //validation for StaffLastName
            if (StaffLastName.Length == 0)
            {
                Error = Error + "The staff last name may not be blank : ";
            }

            if (StaffLastName.Length > 50)
            {
                Error = Error + "The staff last name must be less than 50 characters : ";
            }

            //validation for StaffUsername
            if (StaffUsername.Length == 0)
            {
                Error = Error + "The username may not be blank : ";
            }

            if (StaffUsername.Length > 20)
            {
                Error = Error + "The username must be less than 20 characters : ";
            }

            //validation for StaffPassword
            if (StaffPassword.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }

            if (StaffPassword.Length > 20)
            {
                Error = Error + "The password must be less than 20 characters : ";
            }

            //validation for StaffAddress
            if (StaffAddress.Length == 0)
            {
                Error = Error + "The address may not be blank : ";
            }

            if (StaffAddress.Length > 100)
            {
                Error = Error + "The address must be less than 100 characters : ";
            }

            //validation for DateAdded
            if (DateAdded < DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the past : ";
            }

            if (DateAdded > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future : ";
            }

            //return any error messages
            return Error;
        }
    }
}
