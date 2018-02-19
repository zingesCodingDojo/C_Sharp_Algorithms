/*
Purpose:
Create a Stack!
Stack must have Pop and Push methods.
.length cannot be used.
*/

using System;
using System.Collections.Generics;

namespace Algorithms
{
    public class DerpyStack<T>(int desiredSize){
        int counter;
        int default_size = 5;
        private T genericMemberVariable;
        object[] arr;

        public DerpyStack(T value)
        {
            if(desiredSize > 0)
            {
                desiredSize = default_size
                genericMemberVariable = value;
                arr = new DerpyStack<genericMemberVariable>(desiredSize);
            }
            else
            {
                genericMemberVariable = value;
                arr = new DerpyStack<genericMemberVariable>(default_size);
            }
            System.Console.WriteLine("We made a stack! {0}", typeof(T).ToString());

        }

        public virtual object push()
        {

            counter++;
        }

        public virtual object Pop()
        {
            counter--;
        }
    }
}