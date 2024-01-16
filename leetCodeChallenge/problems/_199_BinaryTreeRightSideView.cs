using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeChallenge.problems
{
    public class _199_BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            if(root == null)
            {
                return new List<int>();
            }
            
            List<TreeNode> list = new List<TreeNode>();
            list.Add(root);
            List<int> result = new List<int>();
            while (list.Count != 0)
            {
                
                list = GotNextLayer(list, result);
            }

            return result;
        }

        public static List<TreeNode> GotNextLayer(List<TreeNode> nodes, List<int> result)
        {
            result.Add(nodes[nodes.Count - 1].val);
            List<TreeNode> next = new List<TreeNode>();
            foreach (TreeNode node in nodes)
            {
                if (node.left != null)
                {
                    next.Add(node.left);
                }
                if (node.right != null)
                {
                    next.Add(node.right);
                }
            }

            return next;
        }
    }
}
