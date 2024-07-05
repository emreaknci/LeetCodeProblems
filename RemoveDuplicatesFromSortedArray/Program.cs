// Problem: https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/

int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0) return 0;

    int k=0;

    for (int i = 1; i < nums.Length; i++)
    {
        if (nums[k] != nums[i])
        {
            k++;
            nums[k] = nums[i];
        }
    }

    return k+1;
}


int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int k = RemoveDuplicates(nums);
Console.WriteLine(k);
