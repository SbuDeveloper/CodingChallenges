//Finding the maximum or minimum sumsubarray of a given size
//Input: [1, 4, 2, 10, 2, 3, 1, 0], k=3
//Output: 15
public class Solution5
{
    //Fixed Size Sliding Window
    //A fixed-size sliding window is useful when you know the exact size of the window you want to examine. 
    //One common example is finding the maximum sum of a subarray of size k in a given array.
    //The time complexity of this solution is O(n), as we only traverse the array once.
    public int MaxSubArrayofK(int[] nums, int k)
    {
        int minSum = 0;
        
        int n = nums.Length;
        for (int i = 0; i < k; i++)
        {
            minSum += nums[i];
        }

        int maxSum = minSum;

        for (int i = k; i < n; i++)
        {
            minSum += nums[i] - nums[i - k];
            maxSum = Math.Max(maxSum, minSum);
        }

        return maxSum;
    }



}
