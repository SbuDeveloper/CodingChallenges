using dotdigital_assessment;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question1
        Question1 question1 = new Question1();
        Console.WriteLine(question1.GetSpottingMetric(new int[] { 2, 1, 3, 0, 1, 5, 0, 0, 6, 7 }));

        //Question 2
        //Question2 question2 = new Question2();
        // should print "MAGENTA"
        //Console.WriteLine(string.Join(", ", question2.ApplyHeat(new List<string> { "BROWN", "YELLOW" }))); 
        // should print "UNKNOWN"
        //Console.WriteLine(string.Join(", ", question2.ApplyHeat(new List<string> { "YELLOW", "BROWN" }))); 

        //Question3
        // Question3 question3 = new Question3();
        // int[] bridge = { 7, 6, 5, 8 };
        // Console.WriteLine(question3.UsageCount(bridge)); // Should print 2
    }

    

}