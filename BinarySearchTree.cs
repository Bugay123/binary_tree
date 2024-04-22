using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_tree
{
    class BinarySearchTree
    {
        public TreeNode Root { get; set; }

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int key)
        {
            Root = InsertRecursive(Root, key);
        }

        private TreeNode InsertRecursive(TreeNode root, int key)
        {
            if (root == null)
            {
                return new TreeNode(key);
            }

            if (key < root.Key)
            {
                root.Left = InsertRecursive(root.Left, key);
            }
            else if (key > root.Key)
            {
                root.Right = InsertRecursive(root.Right, key);
            }

            return root;
        }

        public bool IsBalanced()
        {
            return IsBalancedRecursive(Root) != -1;
        }

        private int IsBalancedRecursive(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftHeight = IsBalancedRecursive(root.Left);
            if (leftHeight == -1)
            {
                return -1;
            }

            int rightHeight = IsBalancedRecursive(root.Right);
            if (rightHeight == -1)
            {
                return -1;
            }

            int heightDiff = Math.Abs(leftHeight - rightHeight);
            if (heightDiff > 1)
            {
                return -1;
            }

            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
