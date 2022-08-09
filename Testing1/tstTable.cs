    using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstTable
    {
        public string Female { get; private set; }
        public string John { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void StaffIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }

        [TestMethod]
        public void StaffDescriptionPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            string TestData = "Female";
            //assign the data to the property
            AnStaff.StaffDescription = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffDescription, TestData);
        }

        [TestMethod]
        public void StaffLastNamePropertyOK()
        {

            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //create some test data
            string TestData = "John";
            //assign the data to the property
            AnStaff.StaffLastName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffLastName, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnStaff.DateJoined = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.DateJoined, TestData);

        }

        [TestMethod]
        public void StaffSalaryPropertyOK()
        {

            //create an instance of the class we want to create 
            clsStaff AnStaff = new clsStaff();
            //create some test data
            decimal TestData = 18;
            //assign the data to the property
            AnStaff.StaffSalary = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffSalary, TestData);

        }

        [TestMethod]
        public void StaffAvailablePropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            Boolean TestData = false;
            //assign the data to the property 
            AnStaff.StaffAvailable = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffAvailable, TestData);

        }

        [TestMethod]
        public void StaffPhoneNoPropertyOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data
            string TestData = "07983833443";
            //assign the data to the property
            AnStaff.StaffPhoneNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AnStaff.StaffPhoneNo, TestData);

        }
    }
}
         




      