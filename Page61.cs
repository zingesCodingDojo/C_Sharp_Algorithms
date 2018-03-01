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
        // NO RECURSION
        public void noRecursionPreorderTraversal ( Page61Node root) {
            Page63Node<Page61Node> stack = new Page63Node<Page61Node>();
            stack.push( root );
            while ( true ) {
                Page61Node curr = stack.pop();
                if( curr == null ) break;
                curr.printValue();
                Page61Node n = curr.getRight();
                if ( n != null ) stack.push ( n );
                n = curr.getLeft();
                if ( n != null ) stack.push ( n );
            }
        }
        // LOWEST COMMON ANSCESTOR
        public Page61Node findLowestCommonAncestor ( Page61Node root, int value1, int value2 ) {
            while ( root != null ) {
                int value = root.getvalue();

                if ( value > value1 && value > value2 ) {
                    root = root.getLeft();
                } else if ( value < value1 && value < value2 ) {
                    root = root.getRight();
                } else {
                    return root;
                }
            }
            return null; // empty tree
        }
        public Page61Node findLowestCommonAncestor ( Page61Node root, Page61Node child1, Page61Node child2) {
            if ( root == null || child1 == null || child2 == null ) {
                return null;
            }
            return findLowestCommonAncestor ( root, child1.getvalue(), child2.getvalue());
        }
    }    
    // Preorder Traversal NO RECURSION
    /*
    Create a stack
    Push the root node of the stack
    While the stack is not empty
        pop a node
        if the node is not null
            print its value
            push the node's right child on the stack
            push the node's left child on the stack
    */
    public class Page63Node<T> {
        public class StackNode<T> {
            public T data;
            public StackNode<T> next;
            
            public StackNode( T data ) {
                this.data = data;
            }
        }
        
        private StackNode<T> top;
        public T pop() {
            if ( top == null ) {
                System.Console.WriteLine("ERROR: 'Stack is empty.'");
            }
            T item = top.data;
            top = top.next;
            return item;
        }
        
        public void push( T item ) {
            StackNode<T> t = new StackNode<T> ( item );
            t.next = top;
            top = t;
        }
        
        public T peek() {
            if ( top == null ) {
                System.Console.WriteLine("ERROR; 'Stack is empty.'");
            }
            return top.data;
        }
        
        public bool isEmpty() {
            return top == null;
        }
    }
    /*
    Given the value of two nodes in a binary search tree, find the lowest (nearest)
    common ancestor. You may assume that both values already exist in the tree.

    Using the tree shown below, assume 4 ane 14 are the two nodes in question.
    The lowest common ancestor would be 8 because it's an ancestor to both 4 and 14
    and there is no node lower on the tree that is an ancestor to both 4 and 14.
        20
    /     \
    8      22
    / \
    4  12
    /  \
    10  14
    */

    /*
    Examine the current node
    If value1 and value2 are both less than the current node's value
        Examine the left child
    If value1 and value2 are both greater than the current node's value
        Examine the right child
    Otherwise
        The current node is the lowest common ancestor.
    */
    // LINE 79
}