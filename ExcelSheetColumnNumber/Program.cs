// Problem: https://leetcode.com/problems/excel-sheet-column-number/description/
int TitleToNumber(string columnTitle)
{
    if (string.IsNullOrEmpty(columnTitle))
        return 0;

    int lastDigitValue = columnTitle[columnTitle.Length - 1] - 'A' + 1;

    int remainingValue = TitleToNumber(columnTitle.Substring(0, columnTitle.Length - 1));

    return remainingValue * 26 + lastDigitValue;
}

Console.WriteLine(TitleToNumber("ZA"));