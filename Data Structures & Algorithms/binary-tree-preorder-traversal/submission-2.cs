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

    List<int> list =[];

    public List<int> PreorderTraversal(TreeNode root) {
       if (root is null) return [];


 Stack<TreeNode> st = [];

 st.Push(root);

 while (st.Count > 0)
 {
     TreeNode temp = st.Pop();

     list.Add(temp.val);

     if(temp.right is not null)
     {
         st.Push(temp.right);
     }

     if(temp.left is not null)
     {
         st.Push(temp.left);
     }

 }
 

 return list;
    }
}