

public class Solution3
{
     public bool FindTarget(TreeNode root, int k) {

        Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

        if(root == null)
        {
            return false;
        }

        var x = k - root.val;
        if(keyValuePairs.ContainsKey(x))
        {
            return true;
        }
        
        keyValuePairs.Add(0,root.val);
        return false;
    }
}


 //Definition for a binary tree node.
 public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
 }
 