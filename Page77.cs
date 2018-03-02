using System;

/*
Write an efficient funciton in C# that deletes characters from a string. Use the prototype
    string removeChars( string str, string remove );
where any character existing in 'remove' must be deleted from 'str'. For example,
given a 'str' of "Battle of the Vowels:Hawaii vs. Grozny" and 'remove' of "aeiou",
the funciton should transform 'str' to "Bttl f th Vwls: Hw vs. Grzny". Justify any
design descisions you make and discuss the efficiency of your solution.
*/

/*
1. Set all the elements in your lookup array to 'false'.
2. Iterate through each character in 'remove', setting the corresponding value in the lookup array to
'true'.
3. Iterate through 'str' with a source and destination index, copying each character only if its
corresponding value in the lookup array is 'false'.
*/

namespace C_Sharp_Mark{
    public class Page76{
        public String removeChars( String str, String remove ){
            char[] s = str.ToCharArray();
            char[] r = remove.ToCharArray();
            bool[] flags = new bool[128]; // assumes ASCII!
            int len = s.Length;
            System.Console.WriteLine("New char array has a length of: " + len + " and your bool array is... " + flags.Length);
            int src, dst;

            // Set flags for characters to be removed
            for( src = 0; src < r.Length; src++){
                flags[r[src]] = true;
            }

            src = 0;
            dst = 0;

            // Now loop through all the characters, copying only if they are not flagged
            while( src < len ){
                if( !flags[(int)s[src]]){
                    s[dst++] = s[src];
                }
                src++;
            }
            return new String( s, 0, dst );
        }
    }
}

// The return of new string( s, 0, dst );
// https://msdn.microsoft.com/en-us/library/ms131423(v=vs.110).aspx
// String Constructor (Char*, Int32, Int32)
/*
[SecurityCriticalAttribute]
[CLSCompliantAttribute(false)]
public unsafe String(
	char* value,
	int startIndex,
	int length
)

Parameters
value
Type: System.Char*
A pointer to an array of Unicode characters.

startIndex
Type: System.Int32
The starting position within value.

length
Type: System.Int32
The number of characters within value to use.

*/