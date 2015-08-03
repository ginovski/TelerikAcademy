namespace SchoolSystem.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNameShouldThrowWhenEmptyOrNull()
        {
            var student = new Student(string.Empty);
        }

        [TestMethod]
        public void TestStudentNameIfValidShouldSetTheName()
        {
            string studentName = "Peter";
            var student = new Student(studentName);

            Assert.AreEqual(studentName, student.Name);
        }
    }
}