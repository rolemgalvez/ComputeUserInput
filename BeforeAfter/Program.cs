//Welcome message
Console.WriteLine("Before After");
Console.WriteLine("------------");
Console.WriteLine();

//Get user input
Console.WriteLine("Let's update some imaginary bank account...");
Console.WriteLine();
Console.Write("Enter the current balance        : ");
bool isBalanceNumber = decimal.TryParse(Console.ReadLine(), out decimal balance);
Console.Write("Enter amount you want to deposit : ");
bool isDepositNumber = decimal.TryParse(Console.ReadLine(), out decimal deposit);
Console.Write("Enter amount you want to withdraw: ");
bool isWithrawNumber = decimal.TryParse(Console.ReadLine(), out decimal withdraw);
Console.WriteLine();

//Show saved values
Console.WriteLine($"Your given current balance is a {isBalanceNumber} number.");
Console.WriteLine($"Its saved value is {balance}");
Console.WriteLine();
Console.WriteLine($"Your given deposit amount is {isDepositNumber} number.");
Console.WriteLine($"Its saved value is {deposit}");
Console.WriteLine();
Console.WriteLine($"Your given withdraw amount is {isWithrawNumber} number.");
Console.WriteLine($"Its saved values is {withdraw}");
Console.WriteLine();

//Show computation
decimal updatedBalance = balance + deposit - withdraw;
Console.WriteLine("The computation is: ");
Console.WriteLine($"{balance} + {deposit} - {withdraw} = {updatedBalance}");
Console.WriteLine();
Console.WriteLine("That's all. Thank you!");
Console.ReadLine();