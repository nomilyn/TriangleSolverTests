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
    }
}
