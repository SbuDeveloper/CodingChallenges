using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliding_window
{
    public class MaxSumSubarray
    {
        public int Max_SumSubarray(int[] arr, int k)
        {
            int n = arr.Length;
            int maxSum = 0;
            for (int i = 0; i < k; i++)
            {
                maxSum += arr[i];
            }

            int windowSum = maxSum;
            for (int i = k; i < n; i++)
            {
                windowSum += arr[i] - arr[i - k];
                maxSum = Math.Max(windowSum, maxSum);
            }

            return maxSum;
        }
    }
}