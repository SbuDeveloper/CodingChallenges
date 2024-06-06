// See https://aka.ms/new-console-template for more information

//What is an average:
//Average is a sum of all number divided by total number
//get the sum of numbers provided
//divide the sum by total number
//e.g total marks of student in class, divided by the total of number of students in class


double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };

var average = array.Sum() / array.Length;
Console.WriteLine($"{"Average:"} {average}");
