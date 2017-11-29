using System;
using SoftwareEngineeringAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class Aidan
    {
        [TestMethod]
        public void TestTimeTable()
        {
            TimeTable timetable = new TimeTable();
            DateTime t = new DateTime(2017, 1, 4);

            timetable.StartTime = t;
            timetable.EndTime = t.AddHours(9);
            timetable.ShiftID = 412;

            Assert.AreEqual(new DateTime(2017, 1, 4), timetable.StartTime);
            Assert.AreEqual(new DateTime(2017, 1, 4, 9, 0, 0), timetable.EndTime);
            Assert.AreEqual(412, timetable.ShiftID);
        }

        [TestMethod]
        public void TestStaff()
        {
            Staff staff = new Staff();

            staff.AuthLevel = (int)Staff.AuthenticationLevel.GP;
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
            Assert.AreEqual("1stName 2ndName", staff.ToString());
        }
        [TestMethod]
        public void TestMetaLayer()
        {
            BusinessLayer ml = BusinessLayer.Instance();

            string test = ml.EncryptString("Hello Test String");

            Assert.AreEqual("Hello Test String", ml.DecryptBytes(test));

            ml.GetShift();
        }
        [TestMethod]
        public void TestShift()
        {
            Shift shift = new Shift();
            shift.ShiftID = 2;
            shift.StaffID = 243;

            Assert.AreEqual(2, shift.ShiftID);
            Assert.AreEqual(243, shift.StaffID);
        }
        [TestMethod]
        public void TestPerscription()
        {
            Perscription perscrip = new Perscription();

            perscrip.description = "Test Description";
            perscrip.DrugID = 2;
            perscrip.EndDate = new DateTime(2017, 4, 7);
            perscrip.PatientID = 5424;
            perscrip.PerscriptionID = 422;
            perscrip.StartDate = new DateTime(2017, 4, 1);

            Assert.AreEqual("Blueberry", perscrip.Name);
            Assert.AreEqual("Test Description", perscrip.description);
            Assert.AreEqual(2, perscrip.DrugID);
            Assert.AreEqual(new DateTime(2017, 4, 7), perscrip.EndDate);
            Assert.AreEqual(5424, perscrip.PatientID);
            Assert.AreEqual(422, perscrip.PerscriptionID);
            Assert.AreEqual(new DateTime(2017, 4, 1), perscrip.StartDate);
        }
        [TestMethod]
        public void TestPatient()
        {
            Patient p = new Patient();

            p.AddressID = 124;
            p.Allergies = "Allergy1, Allergy2, Allergy3";
            p.DoB = new DateTime(1249, 2, 10);
            p.Email = "email@domain.com";
            p.FirstName = "Dave";
            p.LastName = "Davies";
            p.NextOfKin = "Tim";
            p.NoKTelephone = "0917521985";
            p.PatientID = 21470;
            p.Religeon = "dwhad";

            Assert.AreEqual(124, p.AddressID);
            Assert.AreEqual("Allergy1, Allergy2, Allergy3", p.Allergies);
            Assert.AreEqual(new DateTime(1249, 2, 10), p.DoB);
            Assert.AreEqual("email@domain.com", p.Email);
            Assert.AreEqual("Dave", p.FirstName);
            Assert.AreEqual("Davies", p.LastName);
            Assert.AreEqual("Tim", p.NextOfKin);
            Assert.AreEqual("0917521985", p.NoKTelephone);
            Assert.AreEqual(21470, p.PatientID);
            Assert.AreEqual("dwhad", p.Religeon);
            Assert.AreEqual("Dave Davies", p.ToString());
        }
        [TestMethod]
        public void TestDrug()
        {
            Drug d = new Drug();

            d.DrugID = 2;
            d.DrugName = "Blueberry";
            d.Description = "odio donec vitae nisi nam ultrices libero non mattis pulvinar";

            Assert.AreEqual(2, d.DrugID);
            Assert.AreEqual("Blueberry", d.DrugName);
            Assert.AreEqual("odio donec vitae nisi nam ultrices libero non mattis pulvinar", d.Description);
        }
        [TestMethod]
        public void TestAppointment()
        {
            Appointment a = new Appointment();

            a.AppointmentID = 12342;
            a.AppointmentTime = new DateTime(2017, 4, 2, 10, 5, 0);
            a.Attended = true;
            a.Canceled = false;
            a.Description = "Test Description";
            a.EndTime = new DateTime(2017, 4, 2, 10, 15, 0);
            a.PatientID = 412;
            a.StaffID = 21412;

            Assert.AreEqual(12342, a.AppointmentID);
            Assert.AreEqual(new DateTime(2017, 4, 2, 10, 5, 0), a.AppointmentTime);
            Assert.IsTrue(a.Attended);
            Assert.IsFalse(a.Canceled);
            Assert.AreEqual("Test Description", a.Description);
            Assert.AreEqual(new DateTime(2017, 4, 2, 10, 15, 0), a.EndTime);
            Assert.AreEqual(412, a.PatientID);
            Assert.AreEqual(21412, a.StaffID);
        }
    }
}
