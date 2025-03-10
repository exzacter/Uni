using System;

namespace InputNumbers
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number (as an integer): ");
            try
            {
                int number=Convert.ToInt32(Console.ReadLine());
                if (number==1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number==2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number==3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number==4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number==5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number==6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number==7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number==8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number==9)
                {
                    Console.WriteLine("NINE");
                }
                else if (number==10)
                {
                    Console.WriteLine("TEN");
                }
                else if (number==25)
                {
                    Console.WriteLine("TWENTY FIVE");
                }
                else if (number==50)
                {
                    Console.WriteLine("FIFTY");
                }
                else if (number==75)
                {
                    Console.WriteLine("SEVENTY FIVE");
                }
                else if (number==100)
                {
                    Console.WriteLine("ONE HUNDRED");
                }
                else
                {
                    Console.WriteLine("NUMBER NOT VALID");
                }
            }
            catch
            {
                Console.WriteLine("test");
            }
        }
    }
}
