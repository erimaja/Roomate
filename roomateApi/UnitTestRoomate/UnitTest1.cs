using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using roomateApi;
using roomateApi.Controllers;
using System.Collections.Generic;
namespace UnitTestRoomate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetInt()
        {
            var controller = new ValuesController();
            int nume = 6;
            var result = controller.Get(nume);
            Assert.AreEqual(result, "value");

        }
    }
}
