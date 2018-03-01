using System;
/*
Page 58
Each node in a tree is the root of a subtree beginining at that node.
This subtree property is conductive to recursion because recursion 
generally involves solving a problem in terms of similar subproblems and a base case.
Many tree operations can be implemented recursively.
*/
namespace C_Sharp_Mark{
    public class Page55Node{
        private Page55Node left;
        private Page55Node right;
        private int value;

        public Page55Node( Page55Node left, Page55Node right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }

        public Page55Node getLeft() {return left;}
        public Page55Node getRight() {return right;}
        public int getValue() {return value;}

        /*
        Lookup -- O(log(N))
        Fast and simple
        Useful for data storage
        */
        public Page55Node findNode( Page55Node root, int value){
            while ( root != null){
                int currval = root.getValue();
                if ( currval == value ) break;
                if ( currval < value ){
                    root = root.getRight();
                } else { // currval > value
                    root = root.getLeft();
                }
            }
            return root;
        }
        // Recursive Lookup.
        public Page55Node recursiveFindNode( Page55Node root, int value){
            if ( root == null ) return null;
            int currval = root.getValue();
            if ( currval == value ) return root;
            if ( currval < value ){
                return recursiveFindNode ( root.getRight(), value);
            } else { // currval > value 
                return recursiveFindNode ( root.getLeft(), value);
            }
        }
    };
};