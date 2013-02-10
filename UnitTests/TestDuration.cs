using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediaSharp.Model;

namespace UnitTests
{
    [TestClass]
    public class TestDuration
    {
        [TestMethod]
        public void TestConstructor()
        {
            Duration d0 = new Duration(0, 0, 0);
            Duration d1 = new Duration(-1,-2,-3);
            Duration d2 = new Duration(1, 2, 3);
            Duration d3 = new Duration(25, 60, 60);

            Assert.AreEqual(0, d0.Hours, "Duration d0 : heures incorrectes");
            Assert.AreEqual(0, d0.Minutes, "Duration d0 : minutes incorrectes");
            Assert.AreEqual(1, d0.Secondes, "Duration d0 : secondes incorrectes");

            Assert.AreEqual(0, d1.Hours, "Duration d1 : heures incorrectes");
            Assert.AreEqual(0, d1.Minutes, "Duration d1 : minutes incorrectes");
            Assert.AreEqual(1, d1.Secondes, "Duration d1 : secondes incorrectes");

            Assert.AreEqual(1, d2.Hours, "Duration d2 : heures incorrectes");
            Assert.AreEqual(2, d2.Minutes, "Duration d2 : minutes incorrectes");
            Assert.AreEqual(3, d2.Secondes, "Duration d2 : secondes incorrectes");

            Assert.AreEqual(0, d3.Hours, "Duration d3 : heures incorrectes");
            Assert.AreEqual(0, d3.Minutes, "Duration d3 : minutes incorrectes");
            Assert.AreEqual(1, d3.Secondes, "Duration d3 : secondes incorrectes");
        }
    }
}
