using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using MyProgram;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstandLastNameFrequency()
        {
            PersonSortOnFreqAndName sorter = new PersonSortOnFreqAndName();
            NameAndFrequency x = new NameAndFrequency("Brown");
            NameAndFrequency y = new NameAndFrequency("Clive");


            int expected = -1;

            int actual = sorter.Compare(x, y);

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestAddressSort()
        {
            PersonSortOnAddress sorter = new PersonSortOnAddress();
            Person x = new Person("Clive", "Owen", "65 Ambling Way", "31214788");
            
           Person y = new Person("Jimmy", "Smith", "102 Long Lane", "29384857");


            int expected = -1;

            int actual = sorter.Compare(x, y);

            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestPersonCreated()
        {
           
            Person x = new Person("Clive", "Owen", "65 Ambling Way", "31214788");




            string expected = "Clive, Owen,65 Ambling Way,31214788";

            string actual = x.FirstName + ", " +  x.LastName + ","+ x.Address + "," + x.PhoneNumber;

            Assert.AreEqual(expected, actual);


        }




    }
}
