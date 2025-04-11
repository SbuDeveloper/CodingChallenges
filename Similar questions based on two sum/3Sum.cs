using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Similar_questions_based_on_two_sum
{
    public class Solution1
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> arr = [];
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int x = nums[i];
                        int y = nums[j];
                        int z = nums[k];
                        if(x + y + z == 0)
                        {
                            arr.Add([x, y, z]);
                        }
                    }
                    
                }
            }


            return arr;
        }


        public IList<IList<int>> ThreeSum2(int[] nums) {
        
            IList<IList<int>> arr = [];


            return arr;

        }
    }
    
}