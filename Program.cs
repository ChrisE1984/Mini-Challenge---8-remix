//Chris Estrada
//9-15-26
//Mini Challenge 8
//What you did
//Peer Review: Callen Thomason
/*
Flow chart looks good. Some parts of it could be more clear, and some steps might be combines. Some outputs are also marked as processes
Code works great, but you are missing validation on the 'do you want to play again'
I entered 'beans' and it ran the code again.
Your while loops work very well, and TryParse is also great
I would suggest trying a do while loop for the play again feature, but your while loops also work great. 

*/

Console.Clear();

string continuePlaying = "";    //loop needs to encompass entire game so the game can restart if player selects Y

while (continuePlaying != "N") {

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

Console.WriteLine("Would you like to play again? Y/N?");
    continuePlaying = Console.ReadLine().ToUpperInvariant();
}





Console.WriteLine("--------------------------------------------");



string continuePlayingNext = "";    //loop needs to encompass entire game so the game can restart if player selects Y

while (continuePlayingNext != "N") 
{

Console.WriteLine("Hello, Please enter a number:");

string thirdNum = Console.ReadLine();

int numThree;

bool isConvertedThree = int.TryParse(thirdNum, out numThree);

while (isConvertedThree == false)
{
    //if conversion is false this codeblock will execute
    Console.WriteLine("You did not enter a number.");
    Console.WriteLine("Please enter a number.");
thirdNum = Console.ReadLine();

isConvertedThree = int.TryParse(thirdNum, out numThree);

}

Console.WriteLine("Please enter another number:");

string fourthtNum = Console.ReadLine();

int numFour;

bool isConvertedFour = int.TryParse(fourthtNum, out numFour);

while (isConvertedFour == false)
{
    //if conversion is false this codeblock will execute
    Console.WriteLine("You did not enter a number.");
    Console.WriteLine("Please enter a number.");
fourthtNum = Console.ReadLine();

isConvertedFour = int.TryParse(fourthtNum, out numFour);
}

if (numThree > numFour)
{
    Console.WriteLine("The First Number is Greater the Second number.");
}
else if (numThree == numFour)
{
    Console.WriteLine("The First Number is Equal to the Second number.");
}
else 
{
    Console.WriteLine("The First Number is less than the Second number.");
}

if (numThree < numFour)
{
    Console.WriteLine("The Second Number is Greater the First number.");
}
else if (numThree == numFour)
{
    Console.WriteLine("The Second Number is Equal to the First number.");
}
else 
{
    Console.WriteLine("The Second Number is less than the First number.");
}

Console.WriteLine("Would you like to play again? Y/N?");
    continuePlayingNext = Console.ReadLine().ToUpperInvariant();

}
