int operation = 0;

while(operation != 5)
{
    Console.WriteLine("Choose your operation:");
    Console.WriteLine("1 for addition ");
    Console.WriteLine("2 for subtraction");
    Console.WriteLine("3 for multiplication");
    Console.WriteLine("4 for division");
    Console.WriteLine("5 to exit");
    operation = Convert.ToInt32(Console.ReadLine());

    if(operation > 5 || operation < 1)
    {
        Console.WriteLine("You've picked an non existing operation.");  
    }
    else if(operation == 5)
    {
        Environment.Exit(1);    
    }
    else
    {
        Console.WriteLine("Pick first number");
        bool success = Decimal.TryParse(Console.ReadLine(), out decimal firstNumber);
        
        Console.WriteLine("Pick second number");
        bool success2 = Decimal.TryParse(Console.ReadLine(), out decimal secondNumber);

        if (!success || !success2)
        {
            Console.WriteLine("You must pick a number.");
        }
        else
        {
            switch (operation)
            {
                default:
                    Console.WriteLine($"Operation doesn't exists or you error occured. Try again!");
                    break;
                case 1:
                    Console.WriteLine($"{firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"{firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"{firstNumber * secondNumber}");
                    break;
                case 4:
                    Console.WriteLine($"{firstNumber / secondNumber}");
                    break;
            }      
        }  
    }
}

