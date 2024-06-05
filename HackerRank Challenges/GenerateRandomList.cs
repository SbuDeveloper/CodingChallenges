using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HackerRank_Challenges
{
	public class GenerateRandomList
	{
		private readonly List<int> _randomNumbers = new List<int>();
		//Generate random numbers up to a hundred length
		public List<int> GenerateRandomNumber()
		{
			int i = 0;
			var count = 100;
			do
			{
				Random random = new Random();
				_randomNumbers.Add(random.Next(count));
				i++;
			} while (count != i);

			return _randomNumbers;
		}
	} 
}
