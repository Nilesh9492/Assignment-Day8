using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            LengthCalculation length = new LengthCalculation();
            double FirstLine = length.Findlength(3,12,4,15);
            double Secondline = length.Findlength(4,6,3,5);

            Boolean check = FirstLine.Equals(Secondline);
            if (check == true)
            {
                Console.WriteLine("Lines are of equal length");
            }
            else
            {
                Console.WriteLine("Lines are not equal in length");
            }
            if (FirstLine == Secondline)
            {
                Console.WriteLine("both lines are same");
            }
            else if (FirstLine > Secondline)
            {
                Console.WriteLine("First line is greater than Secondline");
            }
            else
            {
                Console.WriteLine("Firstline is less than Secondline ");
            }

        }
    }
}
