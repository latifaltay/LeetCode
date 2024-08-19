public class Solution {
    public int MaxProfit(int[] prices) {
        var min = int.MaxValue;
        var max = 0;

        for(var i = 0; i < prices.Length; i++){
            if(prices[i] < min){
                min = prices[i];
            }else{
                max = Math.Max(max, prices[i] - min);
            }
        }
        return max;
    }
}