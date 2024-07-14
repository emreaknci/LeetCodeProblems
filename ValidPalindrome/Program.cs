// Problem: https://leetcode.com/problems/valid-palindrome/description/
using ValidPalindrome;

bool IsPalindrome(string s)
{
    s = s.RemoveSpecialCharacters().ToLower();
    int leftIndex = 0;
    int rightIndex = s.Length - 1;

    while (leftIndex < rightIndex)
    {
        if (s[leftIndex] != s[rightIndex])
            return false;

        leftIndex++;
        rightIndex--;
    }

    return true;

}


var str = "A man, a plan, a canal: Panama";
Console.WriteLine(IsPalindrome(str));

Console.ReadLine();