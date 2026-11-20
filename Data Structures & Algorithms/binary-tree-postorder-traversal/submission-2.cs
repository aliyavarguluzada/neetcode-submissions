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
    
    public List<int> PostorderTraversal(TreeNode root) {

    List<int> list = [];
        void P(TreeNode r){

        if(r is null) return;
        
        P(r.left);
        P(r.right);

        list.Add(r.val);
        }
        P(root);
        return list;
    }
}