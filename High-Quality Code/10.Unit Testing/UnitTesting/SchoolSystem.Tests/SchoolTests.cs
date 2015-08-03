namespace SchoolSystem.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SchoolSystem;

    [TestClass]
    public class SchoolTests
    {
        private School school;
        private Student student;

        [TestInitialize]
        public void Initialize()
        {
            this.school = new School();
            this.student = new Student("Pesho Goshov");
        }

        [TestMethod]
        public void TestAddStudentAddedStudentShouldGetUniqueID()
        {
            int firstStudentID = 10000;
            this.school.AddStudent(this.student);

            Assert.AreEqual(firstStudentID, this.student.ID);
        }

        [TestMethod]
        public void TestAddStudentStudentShouldBeAddedToTheSchool()
        {
            this.school.AddStudent(this.student);

            Assert.IsTrue(this.school.Students.Contains(this.student));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestAddStudentSchoolShouldBeFullAfter90000Students()
        {
            for (int i = 0; i < 90000; i++)
            {
                this.school.AddStudent(this.student);
            }
        }
    }
}