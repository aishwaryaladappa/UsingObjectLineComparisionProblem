using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class CompareLengthOfTwoLine
    {
        public void CheckEqualityOfLines()
        {


            double x1 = 5, x2 = 4, y1 = 5, y2 = 3;
            double Length1;
            // Console.WriteLine("enter x1,y1,x2,y2:");

            Length1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("LengthOfLine" + Length1);

            double a1 = 5, a2 = 6, b1 = 4, b2 = 3;
            double Length2;
            // Console.WriteLine("enter ,y1,x2,y2:");

            Length2 = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            Console.WriteLine("LengthOfLine" + Length2);
            if (Length1 == Length2)
            {
                Console.WriteLine("both the  lines are equal ");
            }
            else if (Length1 > Length2)
            {
                Console.WriteLine("length1 of line1 is greater than length2 of line2  ");

            }
            else
            {
                Console.WriteLine("length1 of line1 is less than length2 of line2  ");

            }
        }
    }
}