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
if(root is null) return [];
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);

        list.Add(root.val);
        return list;
    }
}