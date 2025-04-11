
//What is the smallest difference in indexes between repeating values in an array
public class SmallestDifference
{
    public int SmallestDiff(int[] nums)
    {
        int n = nums.Length - 1;
        int i = 0;
        int j = n;
        int left = 0;
        int right = 0;
        int minWindow = 0;

        while(n >= 0)
        {
            left = nums[i]; right = nums[j];
            if(left == right)
            {
                minWindow = j - i;
                minWindow = Math.Min(minWindow, j - i);
            }
            else
            {
                if(left > right)
                {
                    i++;
                }
                else
                {
                    if(left < right)
                    {
                        j--;
                    }
                }
            }

            n--;
        }

        return minWindow;
        
    }
    
}