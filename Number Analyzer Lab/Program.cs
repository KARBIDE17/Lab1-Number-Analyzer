//Lab 1 Number Analyzer.
//Use conditional statements to automate the decision-making process.

Console.WriteLine("What is Your Name?");  //  Ask for user information (ex. name) at the beginning of the application, and use it to refer to the user throughout the application.
string name = Console.ReadLine();

do
{

    
    Console.WriteLine("Hey " + name + "! Please enter a number between 1 an 100..."); ////prompts the user to enter an integer between 1 and 100
    int input = int.Parse(Console.ReadLine());
   
    Console.WriteLine("You entered: " + input);//Display the associated result based on the integer range entered

    if (input % 2 == 1 && input < 60) //If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
    {
        Console.WriteLine(name +"... the number you entered is Odd and less than 60");
    }

    if (input % 2 == 0 && input >= 2 && input <= 24) //If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
    {
        Console.WriteLine(name + "... the number you entered is Even and less than 25.");
    }

    if (input % 2 == 0 && input >= 26 && input <= 60) //If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
    {
        Console.WriteLine(name + "... the number you entered is Even and between 26 and 60 inclusive.");
    }

    if (input % 2 == 0 && input > 60 && input < 100)  //If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
    {
        Console.WriteLine(name + "... the number you entered is Even and greater than 60");
    }

    if (input % 2 == 1 && input > 60 && input < 100)
    {
        Console.WriteLine(name + "... the number you entered is Odd and greater than 60");
    }

    if (input > 100)
    {
        Console.WriteLine("Sorry " + name + "... that number is too large for this program.");
    }

    if (input < 1)
    {
        Console.WriteLine("Sorry " + name + "... that number is too small for this program.");
    }
    Console.WriteLine(name + ", would you like to continue? y/n?"); //continue running with a prompt at the end to see if they want to stop. 
    string choice2 = Console.ReadLine();
    while (choice2 != "y")
    {
        Console.WriteLine("See Ya!");
        Environment.Exit(0);
    }
} while (true);