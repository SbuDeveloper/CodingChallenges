using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sliding_window.Leedcode
{
    public class LongestAlternatingSubarray
    {
        public int AlternatingSubarray(int[] nums) 
        {
            
            
            var k = 1;
            var n = nums.Length;
            var ans = 0;
            int i = 0;
            for (i = 0; i < k; i++)
            {
                ans = k - i + 1;
            }

            //int d = ans;
            var j = i;
            for (i = k + 1; i < n; i++)
            {
                j =+ 1;
                var diff = nums[i] - nums[i - 1];
                if(diff == k)
                {
                    //k *= -1;
                    var d = i + 1 - j;
                    if(d > 1)
                    {
                        ans = Math.Max(ans, d);
                    }
                }
            }

            return ans;
        }
    }
}