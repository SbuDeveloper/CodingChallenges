using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	public class Class1
	{
		public string Solution(string S)
		{
			// Implement your solution here

			var s = S.ToArray();
			double sum = s.Sum(d => (double)d);
			double leftSum = 0;
			S = "";
			for (int i = 0; i < s.Length - 1; i++)
			{
				if (leftSum == (sum - leftSum - s[i]))
				{
					S = i.ToString();
				}
				else
				{
					leftSum = leftSum + s[i];
				}
			}
			return S;

		}
	}
}
