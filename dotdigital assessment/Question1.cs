using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace dotdigital_assessment
{
    public class Question1
    {
        public double GetSpottingMetric(int[] results)
        {
            var k = 3;
            var n = results.Length;
            var arr = new ArrayList();
            double avarage = 0;
            var sumofSubarrayofK = 0;
            double smallersAvarageOfSubarry = 0;
            
            for (int i = 0; i < results.Length; i++)
            {
                if(results[i] > 0)
                {
                    arr.Add(results[i]);
                }
            }

            for (int i = 0; i < k; i++)
            {
                sumofSubarrayofK += results[i];
            }

            avarage = sumofSubarrayofK / k;

            double windowAverage = avarage;
            int windowSum = 0;
            for (int i = k; i < arr.Count; i++)
            {
                windowSum = Convert.ToInt32(arr[i]) + Convert.ToInt32(arr[i - k]);
                windowAverage += windowSum / k;
                smallersAvarageOfSubarry = Math.Min(windowAverage, avarage);
            }


            return smallersAvarageOfSubarry;
        }
    }
}