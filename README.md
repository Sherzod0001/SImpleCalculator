# SImpleCalculator
## This program performs the simplest *arithmetic and algebraic* operations

![Alt text](/images/image.png)

----------------------------------------------------

### now familiarize yourself with the methods of the program
1. try-catch method:
```cs
...
try
{
    Console.Write("Enter first number: ");
    string userInputOne = Console.ReadLine();
    int firstNumber = Convert.ToInt32(userInputOne);
    Console.WriteLine("Converting.....");

    Console.Write("Enter second number: ");
    string userInputTwo = Console.ReadLine();
    int secondNumber = Convert.ToInt32(userInputTwo);
    Console.WriteLine("Converting.....");
    Console.WriteLine("");
    Console.WriteLine("Calculation process completed.....");
    Console.WriteLine("");

    AddingMethod(firstNumber, secondNumber);
    SubtractingMethod(firstNumber, secondNumber);
    MultipleyingMethod(firstNumber, secondNumber);
    DividingMethod(firstNumber, secondNumber);
    SquareRootMethod(firstNumber, secondNumber);
    PowMethod(firstNumber, secondNumber);
}
catch (Exception e)
{
    Console.WriteLine("The value you entered cannot be converted to a number !");
    Console.WriteLine("Please enter a number !");
}
...
```

2.Arithmetic methods:
```cs
...

static void AddingMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"When added : {firstNumber + secondNumber}");
}

static void SubtractingMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"When subtracted : {firstNumber - secondNumber}");
}

static void MultipleyingMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"When multiplied : {firstNumber * secondNumber}");
}

static void DividingMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"When divided : {firstNumber / secondNumber}");
}
...
```

3.Algebraic methods:
```cs
...
static void SquareRootMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"When rooting: The square root of {firstNumber} is {Math.Sqrt(firstNumber)}");
    Console.WriteLine($"When rooting: The square root of {secondNumber} is {Math.Sqrt(secondNumber)}");
}

static void PowMethod(int firstNumber, int secondNumber)
{
    Console.WriteLine($"The square and cube of the '{firstNumber}' : {Math.Pow(firstNumber, 2)} , {Math.Pow(firstNumber, 3)}");
    Console.WriteLine($"The square and cube of the '{secondNumber}' : {Math.Pow(secondNumber, 2)} , {Math.Pow(secondNumber, 3)}");
}
...
```
4.Result:

![Result](/images/image-2.png)

