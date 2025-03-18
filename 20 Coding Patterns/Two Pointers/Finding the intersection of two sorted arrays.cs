using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_Coding_Patterns.Two_Pointers
{
    public class Solution4
    {
        public int[] Intersection(int[] nums1, int[] nums2) {

            var outPut = new List<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                map[nums1[i]] = i;
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (map.ContainsKey(nums2[i])) {
                    if(!outPut.Contains(nums2[i]))
                        {
                            outPut.Add(nums2[i]);
                        }
                }
            }

            return outPut.ToArray();
        }

        public int[] Intersection2(int[] nums1, int[] nums2) {

            HashSet<int> s1 = [.. nums1];
            HashSet<int> s2 = [.. nums2];
            s1.IntersectWith(s2);
            int[] ans = new int[s1.Count];
            s1.CopyTo(ans);
            return ans;
        }
        
    }
}