using System;
using System.Collections.Generic;

/*
Write an efficient function to find the first nonrepeated character in a string. For
instance, the first nonrepeated character in "total" is 'o' and the first nonrepeated
character in "teeter" is 'r'. Discuss the efficiency of your algorithm.
*/
// To improve above n2, first understand a more efficient search method to improve
// overall performance of the algorithm.

/*
First, build the character count hash table:
    for each character
        if no value is sotred for the character, store 1
        otherwise, increment the value
Second,scan the string:
    for each character
        return character if count in hash table is 1
    if no character have a count 1, return null
*/

// !!!!!
// !!!!!
// !!!!!
// !!!!!
// A (significantly) further speedup could be achieved by implementing a faster 'char' to 'Character'
// mapping, possibly using an array to cache the mappings, or at least the most frequent mappings (such as for
// ASCII characters). Or use a hash table implementation that could directly store character 'char' values.

namespace C_Sharp_Mark {
    public class Page74{
        public static char? firstNonRepeated( String str ) {
            Dictionary<char, Object> charHash = new Dictionary<char, Object>();
            int i, length;
            char c;
            Object seenOnce = new Object();
            Object seenTwice = new Object();

            length = str.Length;

            // Scan str, building hash table
            for( i = 0; i < length; i++ ){
                c = str[i];
                Object o = charHash[c];
                if ( o == null ){
                    charHash[c] = seenOnce;
                } else if( o == seenOnce){
                    charHash[c] = seenTwice;
                }
            }

            // Search hashtable in order of str
            for( i = 0; i < length; i++ ){
                c = str[i];
                if( charHash[c] == seenOnce){
                    return c;
                }
            }
            return null;
        }
    }
}