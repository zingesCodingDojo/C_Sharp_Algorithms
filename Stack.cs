/*
Purpose:
Create a Stack!
Stack must have Pop and Push methods.
.length cannot be used.
*/

using System;

using System.Collections.Generic;

namespace C_Sharp_Mark
{
    public class DerpyStack<T>
    {
        public int counter;
        int default_size = 5;
        private T[] genericMemberVariable;

        public DerpyStack(int desiredSize)
        {
            if(desiredSize > 0)
            {
                default_size = desiredSize;
                genericMemberVariable = new T[default_size];
            }
            else
            {
                genericMemberVariable = new T[default_size];
            }
            System.Console.WriteLine("We made a stack! {0}", typeof(T).ToString());

        }

        public virtual object push(T element)
        {
            if(counter == default_size)
            {
                System.Console.WriteLine("Error: 'Stack is empty.'");
                return false;
            }
            genericMemberVariable[counter] = element;
            counter++;
            return true;
        }

        // public virtual object Pop()
        // {
        //     counter--;
        // }
    }
}