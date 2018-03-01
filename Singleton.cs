using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Mark
{
	/*
     * Sealed restricts the inheritance
     */
	public sealed class Singleton
	{
		private static int counter = 0;
		private static readonly object obj = new object();
		/*
         * Private constructor ensures that object is not
         * instantiated other than with the class itself.
         */
		private Singleton()
		{
			counter++;
			System.Console.WriteLine("Counter Value " + counter.ToString());
		}
		private static Singleton instance = null;
		/*
         * public property is used to return only one instance of the class
         * leveraging on the private property.
         */
		public static Singleton GetInstance
		{
			/*
             * LAZY initialization. Only works with single thread environment.
             */
			get
			{
				// Double lock checking.
				if (instance == null)
				{
					lock (obj)
					{
						if (instance == null)
							instance = new Singleton();
					}
				}
				return instance;
			}
		}
		public void PrintDetails(string message)
		{
			System.Console.WriteLine(message);
		}
	}
}
