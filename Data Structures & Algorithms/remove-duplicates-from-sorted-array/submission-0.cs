public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int l = 0;
 int r = 0;


 while (r < nums.Length)
 {
     nums[l] = nums[r];

     while (r < nums.Length && nums[l] == nums[r])
     {
         r++;
     }
     l++;
 
 }

 return l;
    }
}