public class Solution {
    public int MaxSubArray(int[] nums) {
        var currentSum = nums[0];
        var maxSum = nums[0];

        for(int i = 1; i < nums.Length; i++)
        {
            currentSum = Math.Max(nums[i], nums[i] + currentSum);
            maxSum = Math.Max(maxSum, currentSum);
        }

        return maxSum;

    }
}