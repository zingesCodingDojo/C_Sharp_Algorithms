using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Mark
{
	public class Tree
	{
		public Node top;
		public Tree()
		{
			top = null;
		}
		public Tree(int initial)
		{
			top = new Node(initial);
		}
		public void Add(int value)
		{
			// non-recursive add
			if (top == null) // The Tree is empty.
			{
				// Add item as base node
				Node NewNode = new Node(value);
				top = NewNode;
				return;
			}
			Node currentnode = top;
			bool added = false;
			do
			{
				// traverse the tree
				if (value < currentnode.value)
				{
					// go left
					if (currentnode.left == null)
					{
						// Add the item
						Node NewNode = new Node(value);
						currentnode.left = NewNode;
						added = true;
					}
					else
					{
						currentnode = currentnode.left;
					}
				}
				if (value >= currentnode.value)
				{
					// go right
					if (currentnode.right == null)
					{
						// Add the item
						Node NewNode = new Node(value);
						currentnode.right = NewNode;
						added = true;
					}
					else
					{
						currentnode = currentnode.right;
					}
				}
			} while (!added);
		}
		public void AddRC(int value)
		{
			// Recursion
			// always start at top!
			AddR(ref top, value);
		}
		private void AddR(ref Node N, int value)
		{
			// private recursive search for where to add the new node
			if (N == null)
			{
				// Node does not exist add it here
				Node NewNode = new Node(value);
				N = NewNode; // Set old Node reference to the newly created node, thus attaching it to the tree
				return;
			}
			if (value < N.value)
			{
				AddR(ref N.left, value);
				return;
			}
			if (value >= N.value)
			{
				AddR(ref N.right, value);
				return;
			}
		}
		public void Print(Node N, ref string s)
		{
			// write out the tree in sorted order to the string newstring
			// implement using recursion
			if (N == null) { N = top; }
			if (N.left != null)
			{
				Print(N.left, ref s);
				s = s + N.value.ToString().PadLeft(3);
			}
			else
			{
				s = s + N.value.ToString().PadLeft(3);
			}
			if (N.right != null)
			{
				Print(N.right, ref s);
			}
		}
	}
}
