What is the output of the following code fragments? Remember to try working this out on paper by tracing through the statements and then input the code into your IDE. Run it to see if you are correct, and then see if you can fix the code.

Q1. 
int height = 13;
if ( height <= 12 )
  Console.WriteLine("Low Bridge: ");
  Console.WriteLine("proceed with caution.");

Q1 - A.
output: proceed with caution. 
This is due to the if statement not being encapsulated with {}. However even if it was there would be no output as 13 is > 12 and no else statement.

Q2. 
int sum = 21;
if ( sum != 21 )
  Console.WriteLine("You win ");
else 
  Console.WriteLine("You lose ");
  Console.WriteLine("the prize.");

Q2 - A.
You win 
the prize.

This is because the if statement is valid so reads the line below. however else statement is not therefor the immediate line after does not get printed but line after does. If this was all encapsulated then only "You win" would be printed.

Q3. 
int sum = 7;
if ( sum > 20 ) {
    Console.WriteLine("You win ");
}
else {
    Console.WriteLine("You lose ");
}
    Console.WriteLine("the prize.");

Q3 - A.
you lose
the prize.

This is because the else statement gets called due to sum being < 20, then because the next console.WriteLine command is not part of either it gets printed.
            
