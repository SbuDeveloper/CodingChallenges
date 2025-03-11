

namespace Sliding_window.Leedcode
{
    public class MaximumAverageSubarray
    {
        public double FindMaxAverage(int[] nums, int k) {
            int n = nums.Length;
            double MaxAvarage = 0.0;
            
            for (int i = 0; i < n; i++)
            {
                var sum = 0;
                var windowSum = 0;
                if(k > 1)
                {
                    for (int j = i + 1; j <= k; j++)
                    {
                        sum += nums[j - 1];
                        windowSum += nums[j];
                    }
                }
                else 
                {
                    return nums[i];
                }

                double initialAvgSum = (float)sum / k;
                double windowAvg = (float)windowSum / k;

                var MaxAvarageSum = Math.Max(initialAvgSum, windowAvg);
                if(MaxAvarageSum > MaxAvarage)
                {  
                    MaxAvarage = MaxAvarageSum;
                }
                
            }


            return MaxAvarage;
        }

        public double FindMaxAveragMethod2(int[] nums, int k) 
        {
            int n = nums.Length;
            var sum = 0;

            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }

            var max = sum;
            for (int i = k; i < n; i++)
            {
                sum += nums[i] - nums[i - k];
                max = Math.Max(max, sum);
            }

            return max * 1.0 / k;

            
        }
    }
}