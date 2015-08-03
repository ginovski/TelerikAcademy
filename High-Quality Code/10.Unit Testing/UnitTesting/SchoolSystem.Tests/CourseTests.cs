namespace SchoolSystem.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CourseTests
    {
        private Course course;
        private Student student;

        [TestInitialize]
        public void Initialize()
        {
            this.course = new Course("JavaScript");
            this.student = new Student("Peter");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseNameShouldThrowWhenNullOrEmpty()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void TestCourseNameShouldSetNameWhenValid()
        {
            string courseName = "C#";
            var course = new Course(courseName);

            Assert.AreEqual(courseName, course.Name);
        }

        [TestMethod]
        public void TestAddStudentShouldAddStudentToTheCourse()
        {
            this.course.AddStudent(this.student);

            Assert.IsTrue(this.course.Students.Contains(this.student));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddStudentShouldThrowWhenStudentsAreMoreThanMaxCapacity()
        {
            int maxCapacity = 30;

            for (int i = 0; i < maxCapacity + 1; i++)
            {
                this.course.AddStudent(this.student);
            }
        }

        [TestMethod]
        public void TestRemoveStudentShouldRemoveStudentFromTheCourse()
        {
            this.course.AddStudent(this.student);
            this.course.RemoveStudent(this.student);

            Assert.IsTrue(!this.course.Students.Contains(this.student));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestRemoveStudentShouldThrowWhenStudentIsNotInTheCourse()
        {
            this.course.RemoveStudent(this.student);
        }
    }
}