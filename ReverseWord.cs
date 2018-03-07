using System;

/*
Write a function that reverses the order of the words in a string. For example, your
function should transform the string "Do or do not, there is no try." to "try. no is
there not, do or Do". Assume that all words are space delimited and treat
punctuation the same as letters.
*/

namespace C_Sharp_Mark{
    public class ReverseWord{
        public String m_reverse( String str ){
            // I will be reversing the entier string first and make a new function for it.
            // start and end will be to help me track head and tail of string.
            System.Console.WriteLine("I'm inside the class!~");
            char[] tempStr = str.ToCharArray();
            int start = 0;
            int end = 0;
            int _length = str.Length;
            
            reverseString(tempStr, start, _length-1);

            while( end < _length){
                // We need to start swaping order of chars in words. Right now the string is
                // fully reversed and thus makes little sense!
                if( tempStr[end] != ' ' ){
                    start = end;
                    while( end < _length && tempStr[end] != ' '){
                        System.Console.WriteLine("I'm on line 29.");
                        end++;
                    }
                    end--;
                    reverseString( tempStr, start, end );
                }
                end++;
            }
            return str = new string(tempStr);
        }
        public void reverseString( Char[] str, int start, int end){
            char temporaryChar;
            System.Console.WriteLine("I'm inside the reverseString!~");
            while( end > start ){
                // Grab first char and temp store it
                temporaryChar = str[start];
                System.Console.WriteLine(temporaryChar);
                // Replace first char with last char
                str[start] = str[end];
                // now send end to start from temp char!
                str[end] = temporaryChar;
                // finally, increment start and decrement end to more quickly swap values.
                // Look at Reverse String for another similar solution. Done with strings only.
                start++;
                end--;
            }
        }
    }
}