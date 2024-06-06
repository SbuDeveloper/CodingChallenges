// See https://aka.ms/new-console-template for more information

//Facts
//its a string of number
//find the largest
//solution
//Convert to an array of intergers
//Order by ascending
//get the find and last value in the array


string numbers = "8 3 -5 42 -1 0 0 -9 4 7 4 -4";
var arrNumbers = numbers.Split(' ');
var arr = arrNumbers.Select(int.Parse).ToArray().OrderBy(x => x);

Console.WriteLine($"{arr.Last()} {arr.First()}");
