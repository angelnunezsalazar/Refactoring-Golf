using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WarmUp.Test
{
    [TestClass]
    public class GreeterTests
    {
        [TestMethod]
        public void CanGreet()
        {
            var greeter=new Greeter();
            string greet = greeter.Greet();
            Assert.AreEqual("Hello World", greet);
        }
    }
}
