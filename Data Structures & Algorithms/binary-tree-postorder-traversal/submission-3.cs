/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    
    List<int> list = [];
    public List<int> PostorderTraversal(TreeNode root) {
  if (root is null) return [];

  Stack<TreeNode> st = [];

  TreeNode curr = root;

  while (curr != null || st.Count > 0)
  {

      if (curr is not null)
      {
          st.Push(curr);
          curr = curr.left;
      }
      else
      {
          TreeNode temp = st.Peek().right;

          if (temp is null)
          {
              temp = st.Pop();
              list.Add(temp.val);

              while (st.Count > 0 && temp == st.Peek().right)
              {
                  temp = st.Pop();
                  list.Add(temp.val);
              }
          }
          else
          {
              curr = temp;
          }
      }
  }

  return list;
  }
}