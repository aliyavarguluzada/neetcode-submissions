public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dc = [];


 for (int i = 0; i < nums.Length; i++)
 {
     if (dc.ContainsKey(nums[i]) && i - dc[nums[i]] <= k)
     {
         return true;
     }
     dc[nums[i]] = i;
 }

 return false;
    }
}