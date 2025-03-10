using System;

namespace Microwave
{
    class Microwave
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Please input the number of items: ");
                int items=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please input the amount of time to heat a single serve of the product in seconds: ");
                int time=Convert.ToInt32(Console.ReadLine());
                
                if ( items == 1 ) {
                Console.WriteLine("To heat your food use the following amount of time (in seconds): ");
                Console.WriteLine(time);
                }
                else if ( items == 2) {
                Console.WriteLine("To heat your food use the following amount of time (in seconds): ");
                Console.WriteLine(time + (time * .5));
                }
                else if ( items == 3) {
                Console.WriteLine("To heat your food use the following amount of time (in seconds): ");                    
                Console.WriteLine(time * 2);
                }
                else {
                Console.WriteLine("The maximum recommended items is 3 and therefore I cannot provide a safe cooking time.");                    
                }
            }
            catch {
                Console.WriteLine("Please input a valid integer of items and time");
            }
        }
    }
}