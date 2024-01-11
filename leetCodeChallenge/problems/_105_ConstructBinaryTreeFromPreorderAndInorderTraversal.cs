using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _105_ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            // preorder = [3,9,20,15,7], inorder = [9,3,15,20,7]
            Dictionary<int,int> inorderReverseMap = new Dictionary<int,int>();
            for (int i = 0; i < inorder.Length; i++)
            {
                inorderReverseMap[inorder[i]] = i;
            }

            return BuildTree(preorder, inorder, inorderReverseMap, 0, preorder.Length - 1, 0, inorder.Length - 1);
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder, Dictionary<int,int> inorderReverseMap, int preorderStart, int preorderEnd, int inorderStart, int inorderEnd)
        {
            int currentValue = preorder[preorderStart];
            TreeNode currentNode = new TreeNode(val: currentValue);
            int currentPosInInOrder = inorderReverseMap[currentValue];
            if (currentPosInInOrder > inorderStart)
            {
                currentNode.left = BuildTree(preorder, inorder, inorderReverseMap, preorderStart + 1, preorderStart + (currentPosInInOrder - inorderStart), inorderStart, currentPosInInOrder - 1);
            }

            if(currentPosInInOrder < inorderEnd)
            {
                currentNode.right = BuildTree(preorder, inorder, inorderReverseMap, preorderStart + 1 + (currentPosInInOrder - inorderStart) , preorderStart + preorderEnd , currentPosInInOrder + 1, inorderEnd);
            }

            return currentNode;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
                    }
    }
}
