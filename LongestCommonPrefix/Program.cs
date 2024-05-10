// Problem: https://leetcode.com/problems/longest-common-prefix/description/


string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";


    string prefix = strs[0]; //flower

    for (int i = 1; i < strs.Length; i++)
    {
        while (!strs[i].StartsWith(prefix)) //flowe->flow -> i=2 -> flow->flo->fl 
        {
            prefix = prefix.Substring(0, prefix.Length - 1);

            if (prefix.Length == 0)
                return "";
        }
    }

    return prefix;
}


string[] strs= new[] { 
    "flower",
    "flow",
    "flight"
};





Console.WriteLine(LongestCommonPrefix(strs));


