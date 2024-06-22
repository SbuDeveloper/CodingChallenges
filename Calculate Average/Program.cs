// See https://aka.ms/new-console-template for more information

//Read a file from a provided csv file and calculate avarage amount of the postal codes

using Calculate_Average;

var path = "";
ReadFromCSV readFromCSV = new ReadFromCSV();
var postalCode = readFromCSV.ReadPostalCodesFromCSV(path);
if(postalCode == null){
    Console.WriteLine("No postal codes");
}
else{
    CalculateAverage calculateAverage = new CalculateAverage(postalCode);
    var averages = calculateAverage.avaragePostalCodes();
    foreach (var code in averages)
    {
        Console.WriteLine($"{"PostalCode:"} {code.PostalCodes} {","} {"AverageAmount:"} {code.AvarageAmount}");
    }
}
