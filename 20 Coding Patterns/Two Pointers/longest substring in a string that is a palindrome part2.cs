using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20_Coding_Patterns
{
    public class Solution_Part_2
    {
        //a palidrome is a word that can be spelled the same in reverse
        //Brute-force
        //Time complexity: O(n 3)
        //complexity is in the worst case
        //Space complexity: O(1)

        //longest substring part 2 solidifying my understanding of this problem and two pointer pattern

        public string LongestPalindrome(string s)
        {
            //initialize my two pointers i as starting index and j as last index where j = length - 1
            //initial left as char of index i
            //initial right as char of index j
            //initialize n where n = length

            var testoutput = s[..2]; //abad

            var n = s.Length - 1;
            int i = 0;
            int j = n;
            
            for (i = 0; i < n; i++)
            {
                var left = s[i].ToString();
                for (j = n; j > 0; j--)
                {
                    var right = s[j].ToString();
                    if(left == right)
                    {

                        var result = s.Substring(i,j);
                        return result;
                    }
                }
            }



            return "";
        }
        
        
    }
}