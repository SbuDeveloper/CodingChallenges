// initial speed = 60
// incliantion array = {0, 30, 0, 45, 0}

internal class Program
{
    private static void Main(string[] args)
    {
        int[] inclines = [0, 30, 0, -45, 0]; 
        Console.WriteLine(CalculateFinalSpeed(60, inclines));
    }

    public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations)
    {
        double CurrentSpeed = 0;
        double FinalSpeed = 0;
        for (int i = 0; i <= inclinations.Length - 1; i++)
        {
            if (inclinations[i] == 0)
            {
                CurrentSpeed = initialSpeed;
            }
            else if (inclinations[i] > 0)
            {
                CurrentSpeed = inclinations[i] - initialSpeed;
                initialSpeed = CurrentSpeed;
                FinalSpeed = initialSpeed;
            
            }
            else if (inclinations[i] < 0)
            {
                CurrentSpeed = inclinations[i] + initialSpeed;
                initialSpeed = CurrentSpeed;
                FinalSpeed = initialSpeed;
            }
        }

       
        return Math.Abs(FinalSpeed);
    }
}