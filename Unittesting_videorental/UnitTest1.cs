using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_rental_system;

namespace Unittesting_videorental
{
    [TestClass]

    public class UnitTest1
    {

        Database_Class Obj_Data = new Database_Class();

        [TestMethod]

        public void TestMethod1()//Test case to check the data string//
        {
            string Connection = Obj_Data.ConnString;
            Assert.AreEqual(@"Data Source=DESKTOP-19R6C8C\SQLEXPRESS;Initial Catalog=Videorental_system;Integrated Security=True", Connection);
        }
        [TestMethod]
        public void Test_deleteMovie()// code to check 
        {
            string Message = Obj_Data.CustomerDelete();//Second test case to check the customer delete//
            Assert.AreEqual("customer Details are filled completely", Message);
        }
    }

   
    }




    

