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
            timetable.ShiftID = 412;

            Assert.AreEqual(new DateTime(2017, 1, 4), timetable.StartTime);
            Assert.AreEqual(new DateTime(2017, 1, 4, 9, 0, 0), timetable.EndTime);
            Assert.AreEqual(412, timetable.ShiftID);

            Staff staff = new Staff();

            staff.AuthLevel = (int) Staff.AuthenticationLevel.GP;
            staff.DoB = new DateTime(2017, 4, 6);
            staff.FName = "1stName";
            staff.LName = "2ndName";
            staff.Password = "password";
            staff.StaffID = 243;
            staff.UserName = "Username";

            Assert.AreEqual((int)Staff.AuthenticationLevel.GP, staff.AuthLevel);
            Assert.AreEqual(new DateTime(2017, 4, 6), staff.DoB);
            Assert.AreEqual("1stName", staff.FName);
            Assert.AreEqual("2ndName", staff.LName);
            Assert.AreEqual("password", staff.Password);
            Assert.AreEqual(243, staff.StaffID);
            Assert.AreEqual("Username", staff.UserName);

            BusinessLayer ml = BusinessLayer.Instance();
            DbConection db = DbFactory.instance();
            Assert.IsTrue(db.OpenConnection());
            Assert.IsTrue(db.CloseConnection());            
        }
    }
}
