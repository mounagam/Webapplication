using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using azuredevopsunittest;

namespace azuredevopsunittest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Addition()
        {
            int a = 5;
            int b = 4;
            int c;
            c = service.add(a, b);
            Assert.AreEqual("7", c.ToString(), "Addition method success");
        }
        [TestMethod]
        public void Multiplication()
        {
            int a = 5;
            int b = 4;
            int c;
            c = service.multi(a, b);
            Assert.AreEqual("20", c.ToString(), "Multiplication method success");
        }
        [TestMethod]
        public void Minus()
        {
            int a = 5;
            int b = 4;
            int c;
            c = service.minus(a, b);
            Assert.AreEqual("1", c.ToString(), "Minus method success");
        }
    }
}
