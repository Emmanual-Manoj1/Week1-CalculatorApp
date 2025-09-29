

// prints the txt for user to enter the first number
Console.WriteLine("Enter the first number: ");
// takes first number as input from the user
int firstNumber = Convert.ToInt32(Console.ReadLine());

// prints the txt for user to enter the second number
Console.WriteLine("Enter the second number: ");
// takes second number as input from the user
int secondNumber = Convert.ToInt32(Console.ReadLine()); 

//Adds the both number
int result = firstNumber + secondNumber;    

//prints out the result 
Console.WriteLine("The Sum of {0} and {1} is {2}",firstNumber, secondNumber, result); 