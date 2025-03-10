using System;

namespace DoCasting
{
    class DoCasting
    {
        static void Main(string[] args)
        {
            int sum = 17;
            int count = 5;
            int intAverage = sum/count;
            Console.WriteLine(intAverage);
            Console.WriteLine("Correct for full integer, but not for a float value.");

            double doubleAverage = sum/count;
            Console.WriteLine(doubleAverage);
            Console.WriteLine("Still incorrect.");

            double anotherdoubleAverage = (double)sum / count;
            Console.WriteLine(anotherdoubleAverage);
            Console.WriteLine("Correct!");
        }
    }
}