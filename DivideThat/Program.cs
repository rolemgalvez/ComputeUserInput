//Welcome message
Console.WriteLine("Divide That");
Console.WriteLine("---------");
Console.WriteLine();

//Get user input
Console.WriteLine("Let's divide some numbers...");
Console.WriteLine();
Console.Write("Enter the dividend number: ");
bool isDividendNumber = double.TryParse(Console.ReadLine(), out double dividend);
Console.Write("Enter the divisor number : ");
bool isDivisorNumber = double.TryParse(Console.ReadLine(), out double divisor);
Console.WriteLine();

//Show saved values
Console.WriteLine($"Your given dividend is a {isDividendNumber} number.");
Console.WriteLine($"Its saved value is {dividend}");
Console.WriteLine();
Console.WriteLine($"Your given divisor is a {isDivisorNumber} number.");
Console.WriteLine($"Its saved value is {divisor}");
Console.WriteLine();

//Show computation
double quotient = dividend / divisor;
Console.WriteLine("The computation is: ");
Console.WriteLine($"{dividend} / {divisor} = {quotient}");
Console.WriteLine();
Console.WriteLine("That's all. Thank you!");
Console.ReadLine();