using System;
using SoftwareEngineeringAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TimeTable timetable = new TimeTable();
            DateTime t = new DateTime(2017, 1, 4);

            timetable.StartTime = t;
            timetable.EndTime = t.AddHours(9);
            timetable.ShiftID = 412

            Assert.AreEqual(new DateTime(2017, 1, 4), timetable.StartTime);
            Assert.AreEqual(new DateTime(2017, 1, 4, 9, 0, 0), timetable.EndTime);
            Assert.AreEqual(412, timetable.ShiftID);
        }
    }
}
