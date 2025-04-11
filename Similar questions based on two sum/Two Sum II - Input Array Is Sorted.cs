public class Solution2
{
    public int[] TwoSum(int[] numbers, int target) //Two pointer solution
    {
        int n = numbers.Length; // where n is the length of the array
        int i = 0;
        int j = n - 1;
        int left = 0;
        int right = 0;
        int[] outPut = [];

        while (numbers[i] + numbers[j] != target)
        {
            left = numbers[i];
            right = numbers[j];
            if(left + right < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        outPut = new int[] {i + 1, j + 1};

        return outPut;


    }
    public int[] TwoSumBinarySearch(int[] numbers, int target) // Binary Search solution
    {
        var n = numbers.Length;
        for (int i = 0; i < n; i++)
        {
            int diff = target - numbers[i];
            int left = i;
            int right = n - 1;
            while(left < right)
            {
                int mid = (left + right) / 2;
                if (numbers[mid] >= diff) {
                    right = mid;
                } else {
                    left = mid + 1;
                }
            }
            if (numbers[left] == diff) {
                return new int[] {i + 1, left + 1};
            }
            
        }

        return new int[] {};
    }

}