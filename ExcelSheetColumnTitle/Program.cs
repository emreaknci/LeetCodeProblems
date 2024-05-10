// Problem: https://leetcode.com/problems/excel-sheet-column-title/description/

using System.Text;

string ConvertToTitle(int columnNumber)
{
    if (columnNumber <= 0)
        return "";

    int remainder = (columnNumber - 1) % 26;
    return ConvertToTitle((columnNumber - 1) / 26) + (char)('A' + remainder);
}

Console.WriteLine(ConvertToTitle(701));