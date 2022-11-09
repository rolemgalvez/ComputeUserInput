//Welcome
Console.WriteLine("Plus Minus");
Console.WriteLine("----------");
Console.WriteLine();

//Get user input
Console.WriteLine("Let's add some numbers...");
Console.WriteLine();
Console.Write("Enter first number : ");
bool firstIsNumber = int.TryParse(Console.ReadLine(), out int firstNumber);
Console.Write("Enter second number: ");
bool secondIsNumber = int.TryParse(Console.ReadLine(), out int secondNumber);
Console.WriteLine();

//Show parse value
Console.WriteLine($"Your first input is a {firstIsNumber} number.");
Console.WriteLine($"Its saved value is {firstNumber}");
Console.WriteLine();
Console.WriteLine($"Your second input is a {secondIsNumber} number.");
Console.WriteLine($"Its saved value is {secondNumber}");
Console.WriteLine();

//Show calculation
int sum = firstNumber + secondNumber;
Console.WriteLine("The competition is:");
Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");
Console.WriteLine();
Console.WriteLine("That's all. Thank you!");
Console.ReadLine();