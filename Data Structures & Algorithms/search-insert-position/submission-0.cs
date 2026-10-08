public class Solution {
    public int SearchInsert(int[] nums, int target) {
         int res = nums.Length;
 int l = 0;
 int r = nums.Length - 1;

 while (l <= r)
 {
     int mid = r - (r - l) / 2;

     if (nums[mid] < target)
     {
         l = mid + 1;
     }
     else if (nums[mid] > target)
     {
         res = mid;
         r = mid - 1;
     }
     else if (nums[mid] == target)
     {
         return mid;
     }

 }


 return res;
    }
}