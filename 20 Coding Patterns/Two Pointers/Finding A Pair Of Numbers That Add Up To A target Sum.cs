using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_Coding_Patterns.Two_Pointers
{
    //Finding a pair of numbers that add up to a target sum in a sorted or unsorted array.
    //Example:
    //Input: [3, 5, 2, 8, 11], target = 10
    //Output: [2, 8]
    public class FindingAPairOfNumbersThatAddUpToATargetSum
    {
        //A suitable pair are two number that can be added to give a target number
        public int[] SuitablePairBruteForce(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.Length; i++)
            {
               for (int j = i + 1; j < nums.Length; j++)
               {
                    x = nums[i];
                    y = nums[j];
                    if(x + y == target)
                    {
                        return new int[] { i, j};
                    }
               }
                
            }

            return new int[] {};;
        }
        public string SuitablePair(int[] nums, int target)
        {
            var outPut = "";
            Dictionary<int, int> map = new Dictionary<int, int>();
            int x = 0;
            int y = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                y = nums[i];
                x = target - y;
                if(map.ContainsKey(x)){
                    outPut = $"{"["}{x}{","}{nums[i]}{"]"}";
                }
                map[y] = i;
                
            }

            return outPut;
        }

        public int[] SuitablePairMethod2(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                map[nums[i]] = i;
            }

            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i) {
                    return new int[] { i, map[complement] };
                }
            }

            return new int[] {};
        }

        public int[] SuitablePairMethod3(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) 
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement)) {
                    return new int[] { i, map[complement] };
                }
            }

            return new int[] {};
        }

    }
}