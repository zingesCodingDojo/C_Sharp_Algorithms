using System;

namespace Algorithms
{
    class SLL
    {
        // add(object)
        // add( int position, object)
        // remove
        // isEmpty
        // is Full ( return false )
        // replace ( int position, object )
        // getEntry
        // contains
        // clear
        // getLength
        private Node headNode;
        public bool add ( int position, object newEntry)
        {
            Node tmp = headNode;
            if ( position >= 1)
            {
                Node newNode = new Node(newEntry);
                if ( isEmpty() || position == 1)
                {
                    newNode.setNextNode(tmp);
                    headNode = newNode;
                    return true;
                }
                else
                {
                    for ( int i = 0; i < (position -1); i++)
                    {
                        tmp = tmp.getNextNode();
                    }
                }
            }
        }
        public bool add ( object newEntry)
        {

        }
        public bool isEmpty ()
        {
            return false;
        }
    }
}