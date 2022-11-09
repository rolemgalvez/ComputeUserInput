//Welcome message
Console.WriteLine("Multiply It");
Console.WriteLine("-----------");
Console.WriteLine();

//Get user input
Console.WriteLine("Let's mulply some numbers...");
Console.WriteLine();
Console.Write("Enter the multiplicand number: ");
bool isMultiplicandNumber = double.TryParse(Console.ReadLine(), out double multiplicand);
Console.Write("Enter the multiplier number  : ");
bool isMultiplierNumber = double.TryParse(Console.ReadLine(), out double multiplier);
Console.WriteLine();

//Show parse values
Console.WriteLine($"Your given multiplicand is a {isMultiplicandNumber} number.");
Console.WriteLine($"Its saved value is {multiplicand}");
Console.WriteLine();
Console.WriteLine($"Your given multiplier is a {isMultiplicandNumber} number.");
Console.WriteLine($"Its saved value is {multiplier}");
Console.WriteLine();

//Show computation
double product = multiplicand * multiplier;
Console.WriteLine("The computation is:");
Console.WriteLine($"{multiplicand} x {multiplier} = {product}");
Console.WriteLine();
Console.WriteLine("That's all. Thank you!");
Console.ReadLine();