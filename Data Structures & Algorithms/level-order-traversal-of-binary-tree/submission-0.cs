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
    public List<List<int>> LevelOrder(TreeNode root) {
       List<List<int>> list = [];

Queue<TreeNode> queue = [];

queue.Enqueue(root);

while (queue.Count > 0)
{
    List<int> level = [];

    for (int i = queue.Count; i > 0; i--) 
    {
        TreeNode temp = queue.Dequeue();
        
        if(temp is not null)
        {
            level.Add(temp.val);
            queue.Enqueue(temp.left);
            queue.Enqueue(temp.right);

        }
    }
    if(level.Count > 0)
    {
        list.Add(level);
    }
}


return list;
    }
}
