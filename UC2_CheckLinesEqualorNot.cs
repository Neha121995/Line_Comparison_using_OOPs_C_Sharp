using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison_using_OOPs
{
    class UC2_CheckLinesEqualorNot
    {
        
        public static void calLine()
        {
            Console.WriteLine("Welcome to the Line Comparision Computation Program");
            Console.WriteLine("Enter your X1,X2,Y1,Y2:");
            int X1 = Convert.ToInt32(Console.ReadLine());
            int X2 = Convert.ToInt32(Console.ReadLine());
            int Y1 = Convert.ToInt32(Console.ReadLine());
            int Y2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your X1 is: " + X1 + "\nYour X2 is: " + X2 + "\nYour Y1 is: " + Y1 + "\nYour Y2 is: " + Y2);

            Console.WriteLine("Enter your A1,A2,B1,B2:");
            int A1 = Convert.ToInt32(Console.ReadLine());
            int A2 = Convert.ToInt32(Console.ReadLine());
            int B1 = Convert.ToInt32(Console.ReadLine());
            int B2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your A1 is: " + A1 + "\nYour A2 is: " + A2 + "\nYour B1 is: " + B1 + "\nYour B2 is: " + B2);

            double len1 = CalCulateLengthofLine(X1, X2, Y1, Y2);
            double len2 = CalCulateLengthofLine(A1, A2, B1, B2);

            if (len1.Equals(len2))
            {
                Console.WriteLine("The Two lines Are Equals");
            }
            else
            {
                Console.WriteLine("The Two lines Are Not Equals");
            }
        }
        
      
        public static double CalCulateLengthofLine(int X1, int X2, int Y1, int Y2)
        {
            double Lenth_of_Line = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            return Lenth_of_Line;
        }
    }
}
