using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SENG8040A2;
using NUnit.Framework;

namespace TriangleSolverTests
{
    [TestFixture]
    public class TriangleSolverClass
    {
        [Test]
        public void Analyze_Input10and10and10_ResultsEquilateralTriangle()
        {
            //Arrange
            int firstSide = 10; int secondSide = 10; int thirdSide = 10;

            string expectedResult = "These inputs form an Equilateral triangle.";

            //Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input15and15and10_ResultsIsoscelesTriangle()
        {
            //Arrange
            int firstSide = 15; int secondSide = 15; int thirdSide = 10;

            string expectedResult = "These inputs form an Isosceles triangle.";

            //Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input10and15and20_ResultsScaleneTriangle()
        {
            //Arrange
            int firstSide = 10; int secondSide = 15; int thirdSide = 20;

            string expectedResult = "These inputs form a Scalene triangle.";

            //Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input15and15and30_ResultsCannotFormTriangle()
        {
            //Arrange
            int firstSide = 15; int secondSide = 15; int thirdSide = 30;

            string expectedResult = "These inputs CANNOT form a triangle.";

            //Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void Analyze_Input15and30and15_ResultsCannotFormTriangle()
        {
            //Arrange
            int firstSide = 15; int secondSide = 30; int thirdSide = 15;

            string expectedResult = "These inputs CANNOT form a triangle.";

            //Act
            string actualResult = TriangleSolver.Analyze(firstSide, secondSide, thirdSide);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
