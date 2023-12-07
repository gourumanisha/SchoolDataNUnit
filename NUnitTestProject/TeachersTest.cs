using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolDataNUnit;

namespace NUnitTestProject
{
    [TestFixture]
    public class TeachersTest
    {
        [Test]
        public void TestTeacherName()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Prathap Reddy";
            // Act
            string teacherName = myTeacher.Name;
            // Assert
            Assert.AreEqual("Prathap Reddy", teacherName);
        }
        [Test]
        public void TestClassId()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Id = 1;
            // Act
            int tecaherId = myTeacher.Id;
            // Assert
            Assert.AreEqual(1, tecaherId);
        }
    }
}
