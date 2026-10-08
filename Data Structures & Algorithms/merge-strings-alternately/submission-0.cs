public class Solution {
    public string MergeAlternately(string word1, string word2) {
         StringBuilder sb = new();

 int i = 0;
 int j = 0;

 int n = word1.Length;
 int m = word2.Length;

 while (i < n || j < m)
 {
     if (i < n)
     {
         sb.Append(word1[i]);
     }

     if (j < m)
     {
         sb.Append(word2[j]);
     }

     i++;
     j++;
 }

 return sb.ToString();
    }
}