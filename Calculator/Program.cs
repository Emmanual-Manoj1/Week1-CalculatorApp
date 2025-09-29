

using System.Numerics;

CalculatorApp();

void CalculatorApp()
{
    float firstNumber = 0;
    float secondNumber = 0;
    float result = 0;
    int choice = 0;


    // prints the txt for user to enter the first number
    Console.WriteLine("Enter the first number: ");
    // takes first number as input from the user
    firstNumber = Convert.ToInt32(Console.ReadLine());


    // prints out the numbers for the operataions
    Console.WriteLine("What operation do you have to do\n1 - Add\n2 - Substract\n3 - Divide\n4 - Multiply");
    // take the input form user for the opertation into the choice variable 
    choice = Convert.ToInt32(Console.ReadLine());


    // prints the txt for user to enter the second number
    Console.WriteLine("Enter the second number: ");
    // takes second number as input from the user
    secondNumber = Convert.ToInt32(Console.ReadLine());


    // checkes the choice and does accordingly
    if (choice == 1)
    {
        //add the numbers 
        result = firstNumber + secondNumber;
        Console.WriteLine($"The Sum of {firstNumber} and {secondNumber} is {result}");
    }
    else if (choice == 2)
    {
        //substracts the numbers 
        result = firstNumber - secondNumber;
        Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {result}");

    }
    else if (choice == 3)
    {
        //divides the numbers 
        result = firstNumber / secondNumber;
        Console.WriteLine($"The division of {firstNumber} and {secondNumber} is {result}");

    }
    else if (choice == 4)
    {
        //multiplies the number
        result = firstNumber * secondNumber;
        Console.WriteLine($"The multipication of {firstNumber} and {secondNumber} is {result}");

    }
    else
    {
        //excutes if the number entered for the choice is invalid 
        Console.WriteLine("Invalid Entry Enter a number from 1-4");
    };
}