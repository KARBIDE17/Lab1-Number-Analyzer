//Lab 1 Number Analyzer.
//Use conditional statements to automate the decision-making process.

Console.WriteLine("What is Your Name?");  //  Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
string name = Console.ReadLine();
bool isValidNum;
do
{
    Console.WriteLine("Hey " + name + "! Please enter a number between 1 an 100..."); ////prompts the user to enter an integer between 1 and 100
    string input = Console.ReadLine();
    isValidNum = int.TryParse(input, out int num);
   
    if (isValidNum == false)
    {
        Console.WriteLine("Please enter only numbers \n");
    }

    if (isValidNum == true)
    {
        Console.WriteLine("You entered: " + num + "\n");//Display the associated result based on the integer range entered
        if (num > 100)
        {
            Console.WriteLine("Sorry " + name + "... that number is too large for this program.");
        }
        else if (num < 1)
        {
            Console.WriteLine("Sorry " + name + "... that number is too small for this program.");
        }
        else if (num % 2 == 1 && num < 60) //If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
        {
            Console.WriteLine(name + "... the number you entered is Odd and less than 60");
        }
        else if (num % 2 == 0 && num >= 2 && num <= 24) //If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
        {
            Console.WriteLine(name + "... the number you entered is Even and less than 25.");
        }
        else if (num % 2 == 0 && num >= 26 && num <= 60) //If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
        {
            Console.WriteLine(name + "... the number you entered is Even and between 26 and 60 inclusive.");
        }
        else if (num % 2 == 0 && num > 60 && num <= 100)  //If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
        {
            Console.WriteLine(name + "... the number you entered is Even and greater than 60");
        }
        else if (num % 2 == 1 && num > 60 && num < 100)
        {
            Console.WriteLine(name + "... the number you entered is Odd and greater than 60");
        }
    }
    Console.WriteLine("\n" + name + ", would you like to continue? y/n?"); //continue running with a prompt at the end to see if they want to stop. 
    string input2 = Console.ReadLine();
    
    while (input2 != "y")
    {
        Console.WriteLine("See Ya!");
        Environment.Exit(0);
    }
} while (true);