using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Mark
{
    public abstract class MyNode{
        private MyNode[] children;

        public MyNode( MyNode[] children){
            this.children = children;
        }
        
        public int getNumChildren(){
            return children.Length;
        }

        public MyNode getChild( int index ){
            return children[ index ];
        }
    }

    public class IntNode : MyNode {
        private int value;
        // Improper implementation! FIX IT!
        public IntNode( MyNode[] children, int value){
            base(children);
            this.value = value;
        }

        public int getValue(){
            return value;
        }
    }
}