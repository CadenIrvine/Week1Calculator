Console.WriteLine("Type in the first number, followed by enter:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number, followed by enter:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} gives {2}", firstNumber, secondNumber, result);
