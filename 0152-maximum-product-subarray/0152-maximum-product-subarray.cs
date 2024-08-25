public class Solution {
    public int MaxProduct(int[] nums) {
        var max = nums[0];
        var currentMin = nums[0];
        var currentMax = nums[0];

        for(var i =1; i < nums.Length; i++)
        {
            var tempCurrentMax = nums[i] * currentMax;
            currentMax = Math.Max(nums[i], Math.Max(nums[i] * currentMax, nums[i] * currentMin));
            currentMin = Math.Min(nums[i], Math.Min(tempCurrentMax, nums[i] * currentMin));

            max = Math.Max(max, currentMax);
        }
        return max;

    }
}