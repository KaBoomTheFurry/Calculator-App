int firstNumber;
int secondNumber;

Console.WriteLine("Choose your operation:");
Console.WriteLine("1 for addition ");
Console.WriteLine("2 for subtraction");
Console.WriteLine("3 for multiplication");
Console.WriteLine("4 for division");
var operation = Console.ReadLine();

Console.WriteLine("Pick first number");
bool success = Int32.TryParse(Console.ReadLine(), out firstNumber);
Console.WriteLine("Pick second number");
bool success2 = Int32.TryParse(Console.ReadLine(), out secondNumber);

if (!success || !success2)
{
    Console.WriteLine("You must pick a number.");
    Environment.Exit(13);
}

switch (operation)
{
    default:
        Console.WriteLine($"Operation doesn't exists or you error occured. Try again!");
        break;
    case "1":
        Console.WriteLine($"{firstNumber + secondNumber}");
        break;
    case "2":
        Console.WriteLine($"{firstNumber - secondNumber}");
        break;
    case "3":
        Console.WriteLine($"{firstNumber * secondNumber}");
        break;
    case "4":
        Console.WriteLine($"{firstNumber / secondNumber}");
        break;
    
}

