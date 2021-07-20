using System;

namespace Line_Comparison_using_OOPs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line comparison problem using oops");
            //UC1_CalculateLength.calculateLength();
            //UC2_CheckLinesEqualorNot.calLine();
            //UC3_LinesGreaterOrLesser.calLine();

            UC4_LineCompareUsingOOPs obj = new UC4_LineCompareUsingOOPs();
            obj.calLine();
            obj.Operation();
        }
    }
}
