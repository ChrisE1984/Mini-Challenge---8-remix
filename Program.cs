using System.Globalization;

Console.Clear();


Console.WriteLine("Hello, Please enter a number:");

string firstNum = Console.ReadLine();

int num;

bool isConverted = int.TryParse(firstNum, out num);

while (isConverted == false)
{
    //if conversion is false this codeblock will execute
    Console.WriteLine("You did not enter a number.");
    Console.WriteLine("Please enter a number.");
firstNum = Console.ReadLine();

isConverted = int.TryParse(firstNum, out num);

}

Console.WriteLine("Please enter another number:");

string secondNum = Console.ReadLine();

int numTwo;

bool isConvertedTwo = int.TryParse(secondNum, out numTwo);

while (isConvertedTwo == false)
{
    //if conversion is false this codeblock will execute
    Console.WriteLine("You did not enter a number.");
    Console.WriteLine("Please enter a number.");
firstNum = Console.ReadLine();

isConvertedTwo = int.TryParse(secondNum, out numTwo);

}

Console.WriteLine("Your numbers add up to " + (num+numTwo) + ".");