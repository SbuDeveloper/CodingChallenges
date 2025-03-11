
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = [0,0,0,0];
        IList<IList<int>> Outputarr = [];
        var output = ThreeSum(input);

        
        Console.WriteLine("Hello, World!");
    }

    public static IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> arr = [];
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                     if(nums[i] + nums[j] + nums[k] == 0){
                        arr.Add([nums[i], nums[j], nums[k]]);
                    }

            }
        }
        }


        return arr;
    }
}