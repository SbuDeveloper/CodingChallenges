// See https://aka.ms/new-console-template for more information


int[] nums = { 1 , 2 , 1 };
for (int i = 0; i <= nums.Length - 1; i++)
{
    nums.Append(nums[i]);
}

Console.WriteLine(nums);
Console.ReadKey();
