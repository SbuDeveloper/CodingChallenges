using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliding_window.Leedcode
{
    public class MaximumSubarray
    {
        //Incorrect needs a relook
        public int MaxSubArray(int[] nums)
        {
            var sum = 0;
            var MaxSum = 0;
            var n = nums.Length;
            var i = 1;
            for (i = 1; i < 0; i++)
            {
                sum = nums[i] + nums[i - 1];
            }

            var windowSum = 0;
            n = 2;
            for (int j = 2; j < n; j++)
            {
                windowSum += nums[j];

                n = j + 1;
            }

            return MaxSum;
        }

        

    }
}