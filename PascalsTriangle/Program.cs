//// Problem: https://leetcode.com/problems/pascals-triangle/description/

IList<IList<int>> Generate(int numRows)
{
    IList<IList<int>> result = new List<IList<int>>();
    if (numRows <= 0)
        return result;

    for (int i = 0; i < numRows; i++)
    {
        int[] rowNumbers = new int[i + 1];
        rowNumbers[0] = 1; //first index must be 1
        rowNumbers[rowNumbers.Length - 1] = 1; //last index must be 1

        for (int j = 1; j < i; j++)
        {
            rowNumbers[j] = result[i - 1][j - 1] + result[i - 1][j]; //C(5,2) = C(4,1)+C(4,2)
        }

        result.Add(rowNumbers);
    }

    return result;
}

var result = Generate(5);

Console.WriteLine();