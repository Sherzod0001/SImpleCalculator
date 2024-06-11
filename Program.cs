using System;

Console.WriteLine("Welcome to Calculator Application");

while (true)
{
    try
    {
        string userValueOne;
        string userValueTwo;
        decimal firstNumber;
        decimal secondNumber;

        userValueOne = GetUserInputByMessage("Enter first number:  ");
        Console.WriteLine("Converting.....");
        firstNumber = Convert.ToDecimal(userValueOne);

        userValueTwo = GetUserInputByMessage("Enter second number:  ");
        Console.WriteLine("Converting.....");
        secondNumber = Convert.ToDecimal(userValueTwo);

        PrintText("\nCalculation process completed.....\n");

        GetToAdd(firstNumber, secondNumber);
        GetToSubtract(firstNumber, secondNumber);
        GetToMultiple(firstNumber, secondNumber);
        GetToDivided(firstNumber, secondNumber);
        GetToSquareRoot(firstNumber, secondNumber);
        GetToPow(firstNumber, secondNumber);
    }
    catch (Exception expection)
    {
        GetExceptionMessage();
    }

    Console.WriteLine("Do you want to use the program again? 👉 y/n👈");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {   
        Console.WriteLine("Thank you for using the programm 🤝");
        break;
    }
    else
    {
        Console.WriteLine("Let's continue  🤝");
    }
}

static void GetToAdd(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"When added : {firstNumber + secondNumber}");
}

static void GetToSubtract(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"When subtracted : {firstNumber - secondNumber}");
}

static void GetToMultiple(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"When multiplied : {firstNumber * secondNumber}");
}

static void GetToDivided(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"When divided : {firstNumber / secondNumber}");
}

static void GetToSquareRoot(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"When rooting: The square root of {firstNumber} is {Math.Sqrt((double)firstNumber)}");
    Console.WriteLine($"When rooting: The square root of {secondNumber} is {Math.Sqrt((double)secondNumber)}");
}

static void GetToPow(decimal firstNumber, decimal secondNumber)
{
    Console.WriteLine($"The square and cube of the '{firstNumber}': Square: {Math.Pow((double)firstNumber, 2)} , Cube: {Math.Pow((double)firstNumber, 3)}");
    Console.WriteLine($"The square and cube of the '{secondNumber}': Square: {Math.Pow((double)secondNumber, 2)}, Cube: {Math.Pow((double)secondNumber, 3)}");
}

static string GetUserInputByMessage(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

static void PrintText(string message)
{
    Console.WriteLine(message);
}

static void GetExceptionMessage()
{
    Console.WriteLine("The value you entered cannot be converted to a number !");
    Console.WriteLine("Please enter a number !");
}