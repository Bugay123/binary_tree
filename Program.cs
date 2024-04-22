namespace binary_tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] balancedKeys = { 10, 5, 15, 3, 7, 13, 17 };
            int[] unbalancedKeys = { 10, 5, 15, 3, 7, 13, 20, 21 };

            BinarySearchTree balancedBST = new BinarySearchTree();
            BinarySearchTree unbalancedBST = new BinarySearchTree();

            foreach (int key in balancedKeys)
            {
                balancedBST.Insert(key);
            }
            foreach (int key in unbalancedKeys)
            {
                unbalancedBST.Insert(key);
            }

            Console.WriteLine("Is balanced BST balanced? " + balancedBST.IsBalanced());
            Console.WriteLine("Is unbalanced BST balanced? " + unbalancedBST.IsBalanced());
        }
    }
}
