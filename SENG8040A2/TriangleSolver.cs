using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040A2
{
    class TriangleSolver
    {
        public static string Analyze(int firstSide, int secondSide, int thirdSide)
        {
            string result = null;
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            { 
                throw new InvalidCastException("Invalid Inputs");
            }


            if ((firstSide + secondSide > thirdSide) && (firstSide + thirdSide > secondSide) && (secondSide + thirdSide > firstSide))
            {
                
                if ((firstSide == secondSide) && (secondSide == thirdSide) && (firstSide == thirdSide))
                {
                    result = "These inputs form an Equilateral triangle.";
                }
                
                else if ((firstSide == secondSide) || (firstSide == thirdSide) || (secondSide == thirdSide))
                {
                    result = "These inputs form an Isosceles triangle.";
                }
                
                else if ((firstSide != secondSide) && (secondSide != thirdSide) && (thirdSide != firstSide))
                {
                    result = "These inputs form a Scalene triangle.";
                }
            }
            
            else
            {
                result = "These inputs CANNOT form a triangle.";
            }
            return result;
        }

    }
}
