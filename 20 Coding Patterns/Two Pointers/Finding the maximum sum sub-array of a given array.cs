
public class Solution3
{
    //Method 1 Brute force
    public int MaxSubArray(int[] nums) {
        //int sum = 0;
        int maxSum = 0;
        

        for (int i = 0; i < nums.Length; i++)
        {
            var sum = nums[i];
            if(nums.Length > 1)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sum += nums[j];
                    maxSum = Math.Max(maxSum, sum);
                }
            }
            else
            {
                maxSum = nums[i];
                maxSum = Math.Max(maxSum, sum);
            }
            
        }


        return maxSum;
        
    }

    public int MaxSubArray2(int[] nums) {
        int ans = nums[0], f = nums[0];

        for (int i = 1; i < nums.Length; ++i) {

            f = Math.Max(f, 0) + nums[i];
            ans = Math.Max(ans, f);

        }
        
        return ans;
    }

}