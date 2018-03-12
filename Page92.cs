using System;
/*
Page 92
Implement a funciton to perform a fbinary search on a sorted array of integers to find
the index of a given integer. Use this method declaration:
    int binarySearch( int[] array, int lower, int upper, int target);
Comment on the efficiency of this search and compare it with other search methods.

NOTE: from book
    You can subtract the lower limit to from the upper limit to find the size of the search space, divide the size
    by two, and add it to the lower limit to find the index of the central element.
*/
namespace C_Sharp_Mark{
    public class Page93Node{
        private Page93Node left;
        private Page93Node right;
        private int value;

        public Page93Node( Page93Node left, Page93Node right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }

        public Page93Node getLeft() {return left;}
        public Page93Node getRight() {return right;}
        public int getValue() {return value;}
    const int NOT_IN_ARRAY = -1; // Helps exit recursion and return us a readible error.
    const int ARRAY_UNORDERED = -2; // Another potential exit if the BST is NOT ordered.
    const int LIMITS_REVERSED = -3; // Limits of lower and upper were not correct... exit out since our recursion is going to fail.
    public int binarySearch( int[] array, int lower, int upper, int target){
        /*
        While we can make assumptions, let's not... let's ask:
        1. Is the value in the array?
        2. Is the array (binary search tree) sorted?
        3. Are the values of lower and upper reversed? -- don't assume!
        */
        int center;
        int range;
        // Check if upper limit is truly upper limit and not less than lower limit
        range = upper - lower;
        if( range < 0 ){
            return LIMITS_REVERSED;
        } else if( range == 0 && array[lower] != target ){
            return NOT_IN_ARRAY; // This checks if the the range became zero and our search value was not within range... then it is not in our array.
        }
        // Similar to limits reversed, now we need to see if our data structure was ordered as intended. Otherwise we will jump out!
        if( array[upper] < array[lower]){
            return ARRAY_UNORDERED;
        }
        // Now we are ready to define our center point to divide and conquer.
        center = lower + ( range / 2);
        if( target == array[center]){
            return center; // We have found our value!
        } else if( target < array[center]){
            // Recurse and modify center by 1 each time. -- If target is less, decrease center which is now upper variable.
            // If target is greater than array[center], ++ center.
            return binarySearch( array, lower, center -1, target);
        } else{
            return binarySearch(array, lower, center + 1, target);
        }
        
    }   
        /* The code below is for page 55.
                Lookup -- O(log(N))
                Fast and simple
                Useful for data storage
                
                // public Page93Node findNode( Page93Node root, int value){
                //     while ( root != null){
                //         int currval = root.getValue();
                //         if ( currval == value ) break;
                //         if ( currval < value ){
                //             root = root.getRight();
                //         } else { // currval > value
                //             root = root.getLeft();
                //         }
                //     }
                //     return root;
                // }
                // Recursive Lookup.
                // public Page93Node recursiveFindNode( Page93Node root, int value){
                //     if ( root == null ) return null;
                //     int currval = root.getValue();
                //     if ( currval == value ) return root;
                //     if ( currval < value ){
                //         return recursiveFindNode ( root.getRight(), value);
                //     } else { // currval > value 
                //         return recursiveFindNode ( root.getLeft(), value);
                //     }
                // }
        */
    };
};