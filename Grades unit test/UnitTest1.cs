using ConsoleAppProject.App03;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades_unit_test
{
    [TestClass]
    public class Grade_Test
    {
        [TestMethod]
        public void TestConvertHighestFail()
        {
            //Arrage the things

            StudentGrades app03 = new StudentGrades();
            //Act

            Grades actualGrades = app03.ConvertToGrades(39);

            //

            Assert.AreEqual(actualGrades, Grades.F);
        }
    }
}