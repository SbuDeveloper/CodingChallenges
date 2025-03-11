
public class FindtheIndexoftheFirstOccurrenceinaString {
    public int StrStr(string haystack, string needle) {
        
        int output = 0;
        var str = "";
        var k = needle.ToArray();
        var n = haystack.Length;

        for (int i = 0; i < k.Length; i++)
        {
            str += haystack.ToArray()[i].ToString();
        }

        if(!string.IsNullOrEmpty(str) && str == needle)
        {
            return output;
        }

        var j = k.Length;
        str = "";
        for (int i = 1; i < n; i++)
        {
            var windStr = haystack.ToArray()[j].ToString();
            str += haystack.ToArray()[i].ToString() + haystack.ToArray()[k.Length - 1].ToString() + windStr;
            if(str == needle)
            {
                output = i;
                return output;
            }
            else
            {
                j++;
            }
        }

        return output;
    }
}
