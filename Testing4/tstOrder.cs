﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }



        [TestMethod]
        public void OrderStatusPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrder.OrderStatus = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderStatus, TestData);


        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Boolean TestData = true;

            //assign the data to the property
            AnOrder.Active = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);


        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            float TestData = 1.5f;

            //assign the data to the property
            AnOrder.TotalAmount = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.TotalAmount, TestData);


        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;

            //assign the data to the property
            AnOrder.OrderDate = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderDate, TestData);


        }

        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.StaffId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffId, TestData);


        }

        [TestMethod]
        public void CustomerIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.CustomerId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerId, TestData);


        }

        [TestMethod]
        public void OrderIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.OrderId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.OrderId, TestData);


        }

        [TestMethod]
        public void ShoeIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            Int32 TestData = 5;

            //assign the data to the property
            AnOrder.ShoeId = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.ShoeId, TestData);


        }

        [TestMethod]
        public void NotePropertyOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create some test data to assign to the property
            string TestData = "Something";

            //assign the data to the property
            AnOrder.Note = TestData;

            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Note, TestData);


        }


        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a Boolean variable to store the results of the validation
            Boolean Found = false;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the Order id 
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;

            //invoke the method
            Found = AnOrder.Find(OrderId);

            //check the order date property 
            if (AnOrder.OrderDate != Convert.ToDateTime("23/12/2022"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestNoteFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

     //create a boolean variable to store the result of the search
        Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 OrderId = 1;
            
            //invoke the method
            Found = AnOrder.Find(OrderId);
        
            //check the note property
            if(AnOrder.Note != "ITEM:COLOUR/SIZE")
            { 
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerIdFound() 
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 CustomerId = 1;

            //invoke the method
            Found = AnOrder.Find(CustomerId);

            //check the customer id property
            if (AnOrder.CustomerId != 11)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 ShoeId = 1;

            //invoke the method
            Found = AnOrder.Find(ShoeId);

            //check the shoe id property
            if (AnOrder.ShoeId != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();

            //create a boolean variable to store the result of the search
            Boolean Found = false;

            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;

            //create some test data to use with the method
            Int32 StaffId = 1;

            //invoke the method
            Found = AnOrder.Find(StaffId);

            //check the staff id property
            if (AnOrder.StaffId != 13)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



       
    }
}






