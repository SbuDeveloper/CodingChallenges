using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Challenges
{
	public class CountSorting
	{
		private readonly List<int> countingSortList = new List<int>();
		public List<int> countingSort(List<int> arr)
		{
			int[] result = new int[100];

			for (int i = 0; i < arr.Count; i++)
			{
				result[arr[i]]++;
			}

			return result.ToList();
		}
	}
}
