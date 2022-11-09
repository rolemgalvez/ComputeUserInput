//Welcome message
Console.WriteLine("Homework Two");
Console.WriteLine("A requirement in \"C# Mastercourse - Tim Corey\"");
Console.WriteLine("------------------------------------------------");
Console.WriteLine();

//Get user input
Console.Write("Please enter your age: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int age);
int ageAfter = age + 25;
int ageBefore = age - 25;
Console.WriteLine();

Console.WriteLine($"You entered a {isNumber} number value.");
Console.WriteLine($"Its digit converted value is {age}.");
Console.WriteLine();

Console.WriteLine($"After 25 years, you will be {ageAfter} year(s) old.");
Console.WriteLine($"25 years ago, you were {ageBefore} year(s) old.");
Console.WriteLine();

Console.WriteLine("That's all. Thank you!");
Console.ReadLine();