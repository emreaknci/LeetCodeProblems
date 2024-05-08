// Problem: https://leetcode.com/problems/valid-parentheses/


bool IsValid(string s)
{
    Stack<char> stack = new();
    Dictionary<char, char> bracketPairs = new()
    {
        { '(', ')' },
        { '[', ']' },
        { '{', '}' }
    };

    foreach (char c in s)
    {
        if (bracketPairs.ContainsKey(c))
            stack.Push(c);

        else if (bracketPairs.ContainsValue(c))
        {
            if (stack.Count == 0 || bracketPairs[stack.Peek()] != c)
                return false;

            stack.Pop();
        }
    }

    return stack.Count == 0;
}

Console.WriteLine(IsValid("()[()]{}"));