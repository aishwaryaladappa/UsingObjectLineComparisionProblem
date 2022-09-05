using System;
namespace LineComparisionProblem
{
    class program
    {
        public static void Main(string[] args)
        {
            LengthOfLine lengthOfLine = new LengthOfLine();
            lengthOfLine.CalculateLengthOfLine();
            CompareLengthOfTwoLine compareLengthOfTwoLine = new CompareLengthOfTwoLine();
            compareLengthOfTwoLine.CheckEqualityOfLines();
            LineEquality lineEquality = new LineEquality();
            lineEquality.CheckEqualityOfLines();


        }

    }
}

