// Problem: https://leetcode.com/problems/roman-to-integer/description/

int RomanToInt(string s)
{
    Dictionary<char, int> romanValues = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

    int sum = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]]) // XC => 90
            sum -= romanValues[s[i]];
        else
            sum += romanValues[s[i]];
    }
    return sum;
}

Console.WriteLine(RomanToInt("III"));
Console.WriteLine(RomanToInt("LVIII"));
Console.WriteLine(RomanToInt("MCMXCIV"));