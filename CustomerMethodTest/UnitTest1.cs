using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static CustomerMethods.CustomerClass;

namespace CustomerMethodTest
{
    [TestClass]
    public class UnitTest1
    {
        string[] strArr;

        [TestInitialize]
        public void TestInitialization()
        {
            strArr = Print100();
        }

        //IF THE NUMBER IS 3, THE RESULT SHOULD BE Fizz.
        [TestMethod]
        public void Print100_3_Fizz()
        {
            //Index
            int i = 3;
            Assert.AreEqual(strArr[i - 1], "3 Fizz");
        }

        //IF THE NUMBER IS 5, THE RESULT SHOULD BE Buzz.
        [TestMethod]
        public void Print100_5_Buzz()
        {
            //Index
            int i = 5;
            Assert.AreEqual(strArr[i - 1], "5 Buzz");
        }

        //IF THE NUMBER IS 15, THE RESULT SHOULD BE FizzBuzz.
        [TestMethod]
        public void Print100_15_FizzBuzz()
        {
            //Index
            int i = 15;
            Assert.AreEqual(strArr[i - 1], "15 FizzBuzz");
        }
    }
}
