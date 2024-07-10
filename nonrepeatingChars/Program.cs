// See https://aka.ms/new-console-template for more information


var str = "abbacde";

var strArry = str.ToArray();
var grp = strArry.GroupBy(x => x.ToString());
var output = "";
output = grp.FirstOrDefault(x => x.Count() == 1).Key;

Console.WriteLine(output);
