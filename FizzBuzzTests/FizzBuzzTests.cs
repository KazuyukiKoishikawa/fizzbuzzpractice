using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void SayGiven1Return1()
        {
            var fz = new FizzBuzz();
            Assert.AreEqual("1", fz.Say(1));
        }
    }
}