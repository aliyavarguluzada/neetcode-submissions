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

    public List<int> InorderTraversal(TreeNode root) {
       
            if (root is null) return [];

            List<int> l = [];

            Stack<TreeNode> s = [];

            TreeNode curr = root;

            while (s.Count > 0 || curr is not null)
            {
                if(curr is not null)
                {
                    s.Push(curr);
                    curr = curr.left;
                }
                else
                {
                    curr = s.Pop();
                    l.Add(curr.val);
                    curr = curr.right;
                }
            }



            return l;
    }
}