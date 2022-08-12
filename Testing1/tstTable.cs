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
        public bool OK { get; private set; }

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
            String TestData = "07983833443";
            //assign the data to the property
            String StaffPhoneNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(StaffPhoneNo, TestData);

        }

        [TestMethod]
        public void FindMethodOK()
        {

            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //Boolean variable to  store tje results of the validation
            Boolean Found = false;
            //create some test data to us with the method
            Int32 StaffPhoneNo = 0798579676;
            //invoke this method
            Found = AnStaff.Find(StaffPhoneNo);
            //test to see if the result is true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestStaffPhoneNoFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //boolean variable to record if the data is OK (assume it is)
            Boolean Found = false;
            //create some test data to use with the method
            String StaffPhoneNo = "0798579676";
            //invoke this method
            Found = AnStaff.Find(StaffPhoneNo);
            // check the staff phone number
            if (AnStaff.StaffPhoneNo != 0798579676)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DateJoinedFound()
        {
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 StaffPhoneNo = 0798579676;
                //invoke this method
                Found = AnStaff.Find(StaffPhoneNo);
                //check the proerty
                if (AnStaff.DateJoined != Convert.ToDateTime("16/05/2011"))
                {
                    OK = false;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void StaffDescription()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if the data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                String StaffDescription = "Female";
                //invoke the method
                Found = AnStaff.Find(StaffDescription);
                //check the property
                if (AnStaff.StaffDescription != "Female")
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }
            [TestMethod]
            public void StaffLastName()
            {
                //create an instance of the class we want to create
                clsStaff AnStaff = new clsStaff();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if the data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 StaffPhoneNo = 0798579676;
                //invoke the method
                Found = AnStaff.Find(StaffPhoneNo);
                //check the hire date
                if (AnStaff.StaffLastName != "Davis")
                {
                    OK = false;
                }
                //test to see if the result is correct
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void StaffAvailable()
            {
                //create an instance of the class we want to create
                clsStaff aStaff = new clsStaff();
                //boolean variable to store the result of the search
                Boolean Found = false;
                //boolean variable to record if the data is OK (assume it is)
                Boolean OK = true;
                //create some test data to use with the method
                Int32 StaffPhoneNo = 0798579676;
                //invoke the method
                Found = aStaff.Find(StaffPhoneNo);
                //check the property
                if (aStaff.StaffAvailable != true)
                {
                    OK = true;
                }
                //test to see that the result is correct
                Assert.IsTrue(OK);
            }


        }
    }
}






      