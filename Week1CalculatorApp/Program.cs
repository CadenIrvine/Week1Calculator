using System.Xml.Serialization;

void CalculatorApp()
{
    //initialize variables
    int firstnumber = 0;
    int secondnumber = 0;
    int result = 0;
    Console.WriteLine("Type in the first number, followed by enter:");
    int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number, followed by enter:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

    //make loop options
    Console.WriteLine("Choose an operation from the following list:");
    Console.WriteLine(" 1 - Add");
    Console.WriteLine(" 2 - Subtract");
    Console.WriteLine(" 3 - Multiply");
    Console.WriteLine(" 4 - Divide");

    //Convert String to interger
    int choice = Convert.ToInt32(Console.ReadLine());

    //IF STATEMENTE
    if (choice == 1)
    {
        Console.WriteLine("Adding {0} and {1} gives {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Subtracting {0} and {1} gives {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 3)
    {
        Console.WriteLine("Multiplying {0} and {1} gives {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 4)
    {
        Console.WriteLine("Dividing {0} and {1} gives {2}", firstNumber, secondNumber, result);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }



