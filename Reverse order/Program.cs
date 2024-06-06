// See https://aka.ms/new-console-template for more information

//Reverse the order of string
//E:g Sbu, reversed: ubs
//convert to string arrang 
//read from backwards in a for loop
//add each charactor to the a new array
//OR
//user Reverse function in LINQ


using System.Linq;

var str = "World";
var reverseStr = str.Reverse().ToArray();
Console.WriteLine($"{String.Concat(reverseStr)}");

//Reverse the order of interger
int number = -123456;
var numReversed = "";
var reversed = number.ToString().Reverse();
if (!char.IsNumber(number.ToString().ToCharArray()[0]))
	numReversed += number.ToString().ToCharArray()[0];
foreach (var item in reversed)
{
	if (char.IsNumber(item))
		numReversed += item;
}

Console.WriteLine($"{int.Parse(numReversed)}");


//Alternative solution
var result = Math.Sign(number) * int.Parse(string.Concat($"{Math.Abs(number)}".Reverse()));
Console.WriteLine($"{result}");