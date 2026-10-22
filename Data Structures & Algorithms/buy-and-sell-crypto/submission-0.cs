public class Solution {
    public int MaxProfit(int[] prices) {
          List<int> ms = [];

 for (int i = 0; i < prices.Length; i++)
 {
     for (int j = i + 1; j < prices.Length; j++)
     {
         if (prices[i] > prices[j]) continue;

         ms.Add(prices[j] - prices[i]);

     }
 }


 return ms.Count > 0 ? ms.Max() : 0;
    }
}
