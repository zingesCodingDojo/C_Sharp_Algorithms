using System;

namespace Algorithms
{
    public class SLL
    {
        SLL next;
        Object data;
        public SLL( Object data)
        {
            this.data = data;
        }
        // Insert infront
        public SLL insertInFront( SLL list, Object data)
        {
            SLL l = new SLL( data );
            l.next = list;
            return l;
        }
        // Traverse
        public SLL find( SLL head, Object data)
        {
            while ( head != null && head.data != data )
            {
                head = head.next;
            }
            return head;
        }
        // Delete!
        bool deleteElement( SLL head, SLL deleteMe)
        {
            SLL elem = head;
            if( deleteMe == head)
            {
                head = elem.next;
                return true;
            }
            while ( elem.next != null )
            {
                if ( elem.next == deleteMe)
                {
                    // Elem is element preceding deleteMe
                    elem.next = deleteMe.next;
                    return true;
                }
                elem = elem.next;
            }
            return false;
        }
        // Insert!
        bool insertElement ( SLL head, SLL insertMe)
        {
            SLL elem = head;
            if( insertMe == head)
            {
                head = elem.next;
                return true;
            }
            while ( elem.next != null)
            {
                if ( elem.next == insertMe)
            }
            return false;
        }
    }
}