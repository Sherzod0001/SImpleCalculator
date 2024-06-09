using System;

Console.WriteLine("Welcome to Calculator Application");

try
{
    Console.Write("Enter first number: ");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Converting.....");


    Console.Write("Enter second number: ");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Converting.....");
    Console.WriteLine("");
    Console.WriteLine("Calculation process completed.....");
    Console.WriteLine("");

    Console.WriteLine("Results:");
    Console.WriteLine($"When added: {firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
    Console.WriteLine($"When subtracted: {firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
    Console.WriteLine($"When multiplied: {firstNumber}  {secondNumber} = {firstNumber * secondNumber}");
    Console.WriteLine($"When divided: {firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
    Console.WriteLine($"When moduluid: {firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
    Console.WriteLine($"{firstNumber} power of {secondNumber} = {Math.Pow(firstNumber, secondNumber)}");
    Console.WriteLine($"When rooting: The square root of {firstNumber} is {Math.Sqrt(firstNumber)}");
    Console.WriteLine($"When rooting: The square root of {secondNumber} is {Math.Sqrt(secondNumber)}");
}
catch (Exception e)
{
    Console.WriteLine("the value you entered cannot be converted to a number !");
    Console.WriteLine("Please enter a number !");
}



