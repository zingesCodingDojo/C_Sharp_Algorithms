using System;

/*
Preorder Traversal
Informally, a preorder traversal involves walking around the tree in a counterclock-
wise manner starting at the root, sticking close to the edges, and printing out the
nodes as you encounter them. For the tree in Figure 5-7, the result is 100, 50,
25, 75, 150, 125, 100, 175. Perform a preorder traversal of a binary search tree, printing
the value of each node.
       100
    /      \
  50        150
 /  \       /   \
25  75    125  175
          /
         110
*/

/*
1. Print out the root (or subtree's root) value.
2. Do a preorder traversal on the left subtree.
3. Do a preorder traversal on the right subtree.
*/

namespace C_Sharp_Mark{
    public class Page61Node{
        private Page61Node left;
        private Page61Node right;
        private int value;
        public Page61Node ( Page61Node left, Page61Node right, int value){
            this.left = left;
            this.right = right;
            this.value = value;
        }
        public Page61Node getLeft() { return left; }
        public Page61Node getRight() { return right; }
        public int getvalue() { return value; }
        public void printValue() { System.Console.WriteLine(value); }
        // Preorder Traversal -- Performs operation on NODE itself. Then left descendants and then right descendants.
        // O(n)
        public void preorderTraversal ( Page61Node root ) {
            if ( root == null ) return;
            root.printValue();
            preorderTraversal( root.getLeft() );
            preorderTraversal( root.getRight() );
        }
        // Inorder Traversal -- Performs operations on left descendants. Then operation on NODE itself and then right descendants.
        // O(n)
        public void inorderTraversal ( Page61Node root ) {
            if ( root == null ) return;
            inorderTraversal ( root.getLeft() );
            root.printValue();
            inorderTraversal ( root.getRight() );
        }
        // Postorder Traversal -- Performs operations on left descendants and then right descendants and finally on NODE itself.
        // O(n)
        public void postorderTraversal ( Page61Node root ) {
            if ( root == null ) return;
            postorderTraversal ( root.getLeft() );
            postorderTraversal ( root.getRight() );
            root.printValue();
        }
    }
}