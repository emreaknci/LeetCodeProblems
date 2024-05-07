// Problem: https://leetcode.com/problems/palindrome-number/

bool IsPalindrome(int x)
{
    string xValue = x.ToString();
    char[] xReverseChar = new char[xValue.Length];

    for (int i = 0; i < xValue.Length; i++)
        xReverseChar[i] = xValue[xValue.Length - 1 - i];


    string reversedString = new string(xReverseChar);
    return xValue.Equals(reversedString);
}


Console.WriteLine(IsPalindrome(121));
Console.WriteLine(IsPalindrome(-121));