using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringAssignment;

namespace UnitTests
{
    [TestClass]
    public class Callum
    {
        [TestMethod]
        public void TestTesting()
        {
            Testing testing = new Testing();
            DateTime t = new DateTime(2017, 12, 12);

            testing.Date = t;
            testing.ReasonForTest = "It hurts";
            testing.Result = "Pain has decreased";
            testing.ID = 256;

            Assert.AreEqual(new DateTime(2017, 12, 12), testing.Date);
            Assert.AreEqual("It hurts", testing.ReasonForTest);
            Assert.AreEqual("Pain has decreased", testing.Result);
            Assert.AreEqual(256, testing.ID);
        }

        [TestMethod]
        public void TestBusinessLayerAddTestHistory()
        {
            BusinessLayer ml = BusinessLayer.Instance();
            bool success = ml.AddTestHistory(6, "it hurts", DateTime.Now);
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestUpdateTest()
        {
            BusinessLayer ml = BusinessLayer.Instance();
            int success = ml.UpdateTest("it hurts", "Pain has decreased", DateTime.Now, 6);
            Assert.AreEqual(1, success);
        }
        
    }
}
