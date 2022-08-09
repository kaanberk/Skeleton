using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffLastName { get; set; }
        public string StaffDescription { get; set; }
        public DateTime DateJoined { get; set; }
        public decimal StaffSalary { get; set; }
        public bool StaffAvailable { get; set; }
        public object StaffPhoneNo { get; set; }
    }
}