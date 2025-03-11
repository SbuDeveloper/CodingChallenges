using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        int[] nums = [2,5,5,11];
        var twoSumArrsy = TwoSumSecondAttemp(nums,  10);


        Console.WriteLine($"{"["}{twoSumArrsy[0]}{","}{twoSumArrsy[1]}{"]"}");
    }
    //First attempt brute force
    //Time complexity: 0(n2)
    //Space : 0(1)

    public static int[] TwoSum(int[] nums, int target){
        int[] array = [];
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            for (int j = i + 1; j <= nums.Length - 1; j++)
            {
                if(nums[j] == target - nums[i]){
                    array = [i, j];
                    
                }
            }
        }


        return array;
    }

    public static int[] TwoSumSecondAttemp(int[] nums, int target){
        int[] array = [];
        Dictionary<int, int> map = new Dictionary<int, int>();
        int count = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            count = target - nums[i];
            if(map.ContainsKey(count)){
                return array = [map[count], i];
            }
            map[nums[i]] = i;
        }


        return array;
    }
}