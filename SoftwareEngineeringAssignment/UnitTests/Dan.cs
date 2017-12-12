using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoftwareEngineeringAssignment;

namespace UnitTests
{
    [TestClass]
    public class Dan
    {
        [TestMethod]
        public void TestBusinessLayerEditPerscription()
        {
            BusinessLayer ml = BusinessLayer.Instance();
            bool success = ml.EditPerscription(5, 5, DateTime.Now, DateTime.Now, "Test Edit Perscription");
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestBusinessLayerAddPerscription()
        {
            BusinessLayer ml = BusinessLayer.Instance();
            bool success = ml.AddPerscription(5, 5, DateTime.Now, DateTime.Now, "Test add perscription");
            Assert.AreEqual(true, success);
        }

        [TestMethod]
        public void TestBusinessLayerAddStaff()
        {
            BusinessLayer ml = BusinessLayer.Instance();
            bool success = ml.AddStaff("Felix", "McGrath", "FMcGrath", "password", 3, 3, DateTime.Now);
            Assert.AreEqual(true, success);
        }




    }
}