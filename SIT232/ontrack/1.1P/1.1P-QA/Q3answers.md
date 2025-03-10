Find all existing issues with the code snippets presented below. It is highly important to try and work this out on paper by tracing through the statements and then input the code into your IDE. Run it to see if you are correct, and then see if you can fix the code.

E1.
int number = 50;
if (number == 50) ; {
  Console.WriteLine("Number is 50");
}

E1 - A.
The problem with this code snippet was the prematurely placed ';' just after the if() statement this caused the code and the compiler to think the if statement was completed with nothing to run if that statement was true.

E2. 
int number = 60;
if (number >== 50 and number <== 100) {
  Console.WriteLine("Number is more than or equal to 50 and less than or equal to 100");
}

E2 - A.
This statement had 2 errors. 

Error 1 = >== or <== was the incorrect symbol to get less than/more than equal to. You need to write >= or <= to have that.

Error 2 = and is not written like that in C#. It is instead written with 2 ampersand's like so &&. This represents (AND) inside C#.

E3. 
Public class Score {
  public static void main(String[] args) {
    double score = 40;
    if score > 40{
      Console.WriteLine("You passed the exam!")
    } else score > 40{
        Console.WriteLine("You failed the exam!")
    }
  }
}

E3 - A.
Error 1 - Due to c# being a case sensitive language. "main" inside the public static void line will error. This needs to be changed to "Main"

Error 2 - "Double score" as the int variable will give of a error due to the space and not calling int. To have a multi word variable you need to have a character connecting e.g double_score or cut it to one word. In this example I will assume you WANT to use double_score and therefore I will use double_score.

Error 3 - Missing brackets on if statement, meaning it wont detect the logic for the if statement.

Error 4- Once the variable has been fixed you are no longer calling the variable inside the if statement due to "score" not existing so we need to replace it with the variable "double_score"

E4. 
Switch (n) {
  case 1: Console.WriteLine("The number is 1");
  case 2: Console.WriteLine("The number is 2"); break;
  Default: Console.WriteLine("The number is not 1 or 2"); 
  break;
}

E4 - A.
Error 1 - Capital S on Switch will error need to be replaced with lowercase

Error 2 - Due to not breaking out of the first case. Code is stuck and wont progress through other cases. Fix by adding break; after the ";" in the first case.

Error 3assumebly - If trying to use "n" as the switch statement, you need to declare n as a variable according to the snippet this variable is going to be an int. so you would add int n = 1 (or whatever number). This then has the code outputting "The number is 1".
