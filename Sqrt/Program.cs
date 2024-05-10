// Problem: https://leetcode.com/problems/sqrtx/description/
int MySqrt(int num)
{
    if (num <= 1) return num;
    long i = 1;
    long square = i * i; //1
    while (num >= square) // 8>=1 - 8>=4 - 8>=9
    {
        i++; // 2 - 3
        square = i * i; // 4 - 9
    }
    return (int)(i - 1); // 3-1=2
}

Console.WriteLine(MySqrt(8));