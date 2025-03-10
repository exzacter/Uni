// The using command allows us to borrow/use classes from that namespace e.g. classes from the 'System' namespace
using System;

// C# ignores blank lines/whitespace

// namespaces are used to organise your code. A namespace is a container for classes and/other namespaces 
namespace helloWorld
{
    // A class is a container for data and methods, every line of code in c# must be inside a class.  
    class Program
    {
        // Main method means anything inside its curly bracketts will be executed 
        static void Main(string[] args)
        {
            // Console is a class inside the system namespace, Console then has a WriteLine() method that is used to output/print the text inside its brackets
            Console.WriteLine("Hello, World!");

            // Adding more than one WriteLine() will output the contents onto a new line and not the same line 
            Console.WriteLine("This will be output on a new line!");
        
            // For every new function we need to ensure the line is ended with a ';' 
            // You can also put basic mathematical equations into the WriteLine() 
            Console.WriteLine(3+3);
            // Note with that equation since its not a string it doesnt need quotes 

            // Another function that you can do it Write() this is similar to WriteLine() however will output multiple functions on the same line it does this by leaving the 'cursor' for text at the end of the line you are working on. In order to then make it go to the next line when you are done printing to the one line the last function should be WriteLine()
            Console.Write("line 1");
            Console.WriteLine("- this is on the same line");

            // using '//' will comment out the line 
            /* where as 
            using '/*'
            will comment out multi line until
            you close it with */
           
            string name = "Lachlan.";
            int age = 25;
            Console.Write("Hi my name is ");
            Console.WriteLine(name);
            Console.Write("I am ");
            Console.Write(age);
            Console.WriteLine(" years old!");
        }
    }
}
