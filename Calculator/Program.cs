
CalculatorApp();

void CalculatorApp()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result;
    int choice = 0;
    Console.WriteLine("Type in the first number followed by the Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Type in the second number followed by the Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option drom the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtratct");
    Console.WriteLine("3 - Divide");
    Console.WriteLine("4 - Multiply");
    choice = Convert.ToInt32(Console.ReadLine());
    
    
    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} from {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} from {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1-4");
    }

    

}


