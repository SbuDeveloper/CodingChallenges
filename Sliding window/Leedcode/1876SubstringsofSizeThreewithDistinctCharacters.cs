

namespace Sliding_window.Leedcode
{
    public class SubstringsofSizeThreewithDistinctCharacters
    {
        //A string is good if there are no repeated characters.
        public int CountGoodSubstrings(string s) //not all test cases passed
        {
            int k = 3;
            var n = s.ToCharArray().Length;
            var str = "";
            var count = 0;
            for (int i = 0; i < n; i++)
            {
                str = s[i].ToString();
                for (int j = i + 1; j < 3; j++)
                {
                    if(!str.Contains(s[j].ToString()))
                    {
                        str += s[j].ToString();
                    }
                }
                if(str.Length == k)
                {
                    count++;
                }

                str = "";
            }

            return count;
        }

        //all test cases passed
        //time complexity O(N)
        public int CountGoodSubstringsMethod2(string s) 
        {
            int k = 3;
            var n = s.ToCharArray().Length;
            var str = "";
            var count = 0;
            for (int i = 0; i < k && n >= k; i++)
            {
                str += s[i].ToString();
                var dist = str.Distinct().Count();
                if(dist == k)
                {
                    count++;
                    str = "";
                }

            }

            str = "";
            for (int j = k; j < n && n >= k; j++)
            {
                str += s[j].ToString() + s[j - 1].ToString() + s[j - 2].ToString();
                var dist = str.Distinct().Count();
                if(dist == k)
                {
                    count++;
                }
                str = "";
            }

            return count;
        }

        public int CountGoodSubstringsMethod3(string s) 
        {
           int k = 3;
            int n = s.Length;
            int maxLength = 0;
            int start = 0;
            int end = 0;
            int count = 0;
            var str = "";
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (end = 0; end < n; end++)
            {
                char currentChar = s[end];
                if(dict.ContainsKey(currentChar))
                {
                    start = dict[currentChar] + 1;
                }

                dict[currentChar] = end;

                
                
            }
            return count;
            
        }
    }
}