using System;

namespace InputNumbers
{
    class SwitchStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an integer): ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    // case [value] where value is what it is detecting and will then output. E.G. below when user inputs 1 it will then execture the line.
                    case 1: Console.WriteLine("One"); break;
                    case 2: Console.WriteLine("Two"); break;
                    case 3: Console.WriteLine("Three"); break;
                    case 4: Console.WriteLine("Four"); break;
                    case 5: Console.WriteLine("Five"); break;
                    case 6: Console.WriteLine("Six"); break;
                    case 7: Console.WriteLine("Seven"); break;
                    case 8: Console.WriteLine("Eight"); break;
                    case 9: Console.WriteLine("Nine"); break;
                    case 10: Console.WriteLine("Ten"); break;
                    case 25: Console.WriteLine("Twenty Five"); break;
                    case 50: Console.WriteLine("Fifty"); break;
                    case 75: Console.WriteLine("Seventy Five"); break;
                    case 100: Console.WriteLine("One Hundred"); break;
                    default: Console.WriteLine("Error: you must enter an integer between 1 and 9 or special numbers between 10 and 100!"); break;
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
