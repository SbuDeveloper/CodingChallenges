using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotdigital_assessment
{
    public class Question3
    {
        public int UsageCount(int[] bridge)
        {
            var count = 0;
            for (int i = 0; i < bridge.Length; i++)
            {
                var j = 0;
                while(j < bridge.Length - 1)
                {
                    bridge[j] = bridge[j] - 2;
                    var usage = bridge[j];
                    if(usage == 0)
                    {
                        return count;
                    }
                    j++;
                }

                count ++;
            }
            return count;
        }

    }
}