using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliding_window.Leedcode
{
    public class MaximumAscendingSubarraySum
    {
        //Brute force
        public int MaxAscendingSum(int[] nums)
        {
            var maxAscendingSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var b = nums[i];
                for (int j = i + 1; j < nums.Length && nums[j] > nums[j - 1]; j++)
                {
                    b += nums[j];
                }

                maxAscendingSum = Math.Max(maxAscendingSum, b);
            }

            return maxAscendingSum;
        } 

        //Linear Scan
        public int MaxAscendingSumUsingLinearScanApproach(int[] nums)
        {
            var maxAscendingSum = 0;
            var currentSubArray = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if(nums[i] <= nums[i - 1])
                    {
                        maxAscendingSum = Math.Max(maxAscendingSum, currentSubArray);
                        currentSubArray = 0;
                    }

                     currentSubArray += nums[i];
                
                 
            }

            return Math.Max(maxAscendingSum, currentSubArray);;


        }

        

    }
}