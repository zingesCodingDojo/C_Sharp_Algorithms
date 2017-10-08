﻿using System;
namespace Algorithms
{
	public class Node
	{
		public int value;
		public Node left;
		public Node right;
		public Node(int initial)
		{
			value = initial;
			left = null;
			right = null;
		}
	}
}
