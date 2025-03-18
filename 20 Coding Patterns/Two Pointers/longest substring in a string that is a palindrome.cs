using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_Coding_Patterns.Two_Pointers
{
    public class Solution2
    {
        //a palidrome is a word that can be spelled the same in reverse
        //Brute-force
        //Time complexity: O(n 3)
        //complexity is in the worst case
        //Space complexity: O(1)
        public string LongestPalindrome(string s) {
            for (int length = s.Length; length > 0; length--)
            {
                int startLength = s.Length - length;
                for (int start = 0; start <= startLength; start++)
                {
                     if (Check(start, start + length, s)) {
                    return s.Substring(start, length);
                }
                }
            }


            return "";
        
        }

        private bool Check(int i, int j, string s)
        {
            int letf = i;
            int right = j - 1;
            while(letf < right)
            {
                if(s[letf] != s[right])
                {
                    return false;
                }

                letf++;
                right--;
            }

            return true;
        }

        //Dynamic Programming
        public string LongestPalindrome2(string s) {
             int n = s.Length;
            bool[,] dp = new bool[n, n];
            int[] ans = new int[] { 0, 0 };

            for (int i = 0; i < n; i++) {
                dp[i, i] = true;
            }

            for (int i = 0; i < n - 1; i++) {
                if (s[i] == s[i + 1]) {
                    dp[i, i + 1] = true;
                    ans = new int[] { i, i + 1 };
                }
            }

            for (int diff = 2; diff < n; diff++) {
                for (int i = 0; i < n - diff; i++) {
                    int j = i + diff;
                    if (s[i] == s[j] && dp[i + 1, j - 1]) {
                        dp[i, j] = true;
                        ans = new int[] { i, j };
                    }
                }
            }

            int start = ans[0];
            int end = ans[1];
            return s.Substring(start, end - start + 1);
        
        }

        //Dynamic Programming
        public string LongestPalindrome3(string s)
        {
            int n = s.Length;
            bool[,] f = new bool[n, n];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; ++j) {
                    f[i, j] = true;
                }
            }

            int k = 0, mx = 1;

            int left = n - 2;
            for (int i = left; i >= 0; --i) {

                var iChar = s[i]; 

                int right =  i + 1;

                for (int j = right; j < n; ++j) {

                    var jChar = s[j]; 

                    f[i, j] = false;
                    if (iChar == jChar) {

                        var middle = j - 1;

                        f[i, j] = f[right, middle];

                        if (f[i, j] && mx < middle + 1) {
                            mx = middle + 1;
                            k = i;
                        }
                    }
                }
            }
            return s.Substring(k, mx);
        }

        
    }
}