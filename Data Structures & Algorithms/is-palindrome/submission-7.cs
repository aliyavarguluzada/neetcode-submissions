public class Solution {
    public bool IsPalindrome(string s) {
      int l = 0;

  StringBuilder sb = new();
  foreach (char c in s)
  {
      if (char.IsLetterOrDigit(char.ToLower(c))) sb.Append(char.ToLower(c));
  }

  char[] word = sb.ToString().ToCharArray();

  int r = word.Length - 1;
  while (l < r)
  {
      if (word[l] != word[r]) return false;

      l++;
      r--;
  }

  return true;
    }
}
