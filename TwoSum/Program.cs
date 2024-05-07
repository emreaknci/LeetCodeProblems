// Problem: https://leetcode.com/problems/two-sum/description/


int[] TwoSum(int[] nums, int target)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        int num = nums[i];
        int remaining = target - num;

        for (int j = i + 1; j < nums.Length; j++)
        {
            if (nums[j] == remaining)
            {
                return new int[] { i, j };
            }
        }
    }

    return new int[] { };
}

int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = TwoSum(nums, target);

Console.WriteLine("Output: [" + result[0] + ", " + result[1] + "]");
