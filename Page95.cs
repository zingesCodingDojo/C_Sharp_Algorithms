using System;
// PERMUTATIONS OF A STRING
/*
Implement a routine that prints all possible orderings of the characters in a string. In
other words, print all permutations that use all the characters from the original string.
For example, given the string "hat", your function should print the strings
"tha", "aht", "tah", "hta", and "hat". Treat each character in the input string as
a distinct character, even if it is repeated. Given the string "aaa", your routine should
print "aaa" six times. You may print the permutations in any order you choose.
*/

// I can immediately see each character must be palced at each index at least once.

/*
    Note from book:
    To find all permutations starting at position n, successively place all allowable
    letters in position n, and for each new letter in position n find all permutations
    starting at position n + 1 (the recursive case).
*/

// Exmaples contain around 3 methods (functions) -- swap, set permutations, and permutation method.

namespace C_Sharp_Mark{
    public class StringPermutations{
        private int counter = 0;
        // private method to swap around! --
        private void swap( ref char a, ref char b ){
            if( a == b ){
                return;
            }
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/xor-operator
            a^=b; // Binary operator predefined for integral types and bool.
            b^=a;
            a^=b;
        }
        public void set_permutations( char[] myArray ){
            int arrayLength = myArray.Length;
            permutation_method( myArray, 0, arrayLength );
            System.Console.WriteLine("Total number of permutations... " + counter);
        }
        private void permutation_method( char[] myArray, int start, int end ){
            int i;
            if( start == end ){
                System.Console.WriteLine(string.Join("", myArray) + "\n\r" + " ");
                counter++;
            } else{
                for( i = start; i < end; i++){
                    swap(ref myArray[start], ref myArray[i]);
                    permutation_method( myArray, start + 1, end);
                    swap( ref myArray[start], ref myArray[i]);
                }
            }
        }
    }
}