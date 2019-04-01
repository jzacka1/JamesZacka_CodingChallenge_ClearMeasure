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
