// See https://aka.ms/new-console-template for more information

//Given a list of integers, count and return the number of times each value appears as an array of integers.
using HackerRank_Challenges;

CountSorting countSorting = new CountSorting();
GenerateRandomList randomList = new GenerateRandomList();
var _countSorting = countSorting.countingSort(randomList.GenerateRandomNumber());
for (int i = 0; i <= _countSorting.Count - 1; i++)
{
	Console.Write($"{_countSorting[i]} {","}");
}





