// Problem: https://leetcode.com/problems/length-of-last-word/
int LengthOfLastWord(string s)
{
    s = s.Trim();
    if (s == null) return 0;

    int lastSpaceIndex=s.LastIndexOf(' ');
    if (lastSpaceIndex == -1) return s.Length;

    s=s.Substring(lastSpaceIndex,s.Length-lastSpaceIndex);

    return s.Length-1;
}

Console.WriteLine(LengthOfLastWord("   fly me   to   the moon  "));