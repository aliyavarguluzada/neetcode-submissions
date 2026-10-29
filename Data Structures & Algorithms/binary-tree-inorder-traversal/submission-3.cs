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
       private List<int> l = [];
    public List<int> InorderTraversal(TreeNode root) {
        if(root is null) return [];

        InorderTraversal(root.left);

        l.Add(root.val);
        InorderTraversal(root.right);
        

        return l;
    }
}