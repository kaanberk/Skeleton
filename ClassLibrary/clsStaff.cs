using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for staff available
        private Boolean mStaffAvailable;
        //public property for active
        public bool StaffAvailable
        {
            get
            {
                // return the private data
                return mStaffAvailable;
            }
            set
            {
                //set the private data 
                mStaffAvailable = value;
            }
        }
        //private date added data member
        private DateTime mDateJoined;
        //public property for date added
        public DateTime DateJoined
        {
            get
            {
                //return the private data
                return mDateJoined;
            }
            set
            {
                //set the private data 
                mDateJoined = value;
            }
        }
        //private data member for the staff phone number
        private Int32 mStaffLastName;
        //public property for the address number
        public int StaffLastName
        {
            get
            {
                //return the private data
                return mStaffLastName;
            }
            set
            {
                //set the value of the private data member
                mStaffLastName = value;
            }
        }

        //private data member for the staff phone number
        private Int32 mStaffPhoneNo;
        //public property for StaffPhone number
        public int StaffPhoneNo
        {
            get
            {
                //return the private data
                return mStaffPhoneNo;
            }
            set
            {
                //set the private data
                mStaffPhoneNo = value;
            }
        }

        public int StaffId { get; set; }
        public string StaffLastName { get; set; }
        public string StaffDescription { get; set; }
        public DateTime DateJoined { get; set; }
        public decimal StaffSalary { get; set; }
        public bool StaffAvailable { get; set; }
        //staffPhoneNo public property
        public Int32 StaffPhoneNo
        {
            get
            {
                //this line of code senda data out of the property
                return mStaffPhoneNo;
            }
            set
            {
                //this line of code allwows data into the property
                mStaffPhoneNo = value;
            }
        }

        public bool Find(int StaffPhoneNo)
        {
            //set the private data members to the test data value
            mStaffPhoneNo = 0798579676;
            mStaffDateJoined = Convert.ToDateTime(16/05/2011);
            //always return true
            return true;
        }

        public bool Find(string staffPhoneNo)
        {
            throw new NotImplementedException();
        }
    }
}