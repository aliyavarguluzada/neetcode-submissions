public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
      List<int> list = [];

 int i = 0;
 int j = 0;

 while (i < m || j < n)
 {
     if (i < m)
     {
         list.Add(nums1[i]);
     }

     if (j < n)
     {
         list.Add(nums2[j]);
     }


     i++;
     j++;
 }

 list.Sort();

 int index = 0;
 foreach (int num in list)
 {
     nums1[index] = list[index];
     index++;
 }
}}