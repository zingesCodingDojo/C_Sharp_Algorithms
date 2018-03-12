using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // TestMergeSort();
			// IsPallindrome.CheckPal("banana");
			// IsPallindrome.CheckPal("BOOOOB");
			// ReverseString.Reverse("Banana");
			// Parallel.Invoke(
			// 	() => PrintStudentMethod(),
			// 	() => PrintEmployeeDetails()
			// );
			// Console.ReadLine();
			// DerpyStack<int> myStack = new DerpyStack<int>(5);
			// myStack.push(5);
			// System.Console.WriteLine("My size is: " + myStack.counter);
			// for(int i = 0; i < myStack.counter ; i++)
			// {
			// 	System.Console.WriteLine(i);
			// }
			
			// System.Console.WriteLine(myStack);

			// Page76 myString = new Page76();
			// string testingString = "Hello Pagessssss";
			// string testingRemovals = "els";

			// System.Console.WriteLine(myString.removeChars(testingString, testingRemovals));
			// string testing_reversingSelf = "Hello World!";
			// ReverseWord reversingSelf = new ReverseWord();
			// System.Console.WriteLine(reversingSelf.m_reverse(testing_reversingSelf));
			// string test85 = "316";
			// int i = 0, num =0;
			// int len = test85.Length;
			// while( i < len ){
			// 	num *= 10;
			// 	num += ( test85[i++] - '0');// remove a 0!
			// }
			// System.Console.WriteLine(num + test85);
			StringPermutations testPerm = new StringPermutations();
			string myTestString = "ABCD";
			char[] myTestStringArray = myTestString.ToCharArray();
			testPerm.set_permutations(myTestStringArray);
			
			// FUN WITH MARK!
			// Page63Node<int> newStack = new Page63Node<int>();
			// newStack.push(5);
			// newStack.push(4);
			// System.Console.WriteLine(newStack.pop());
			// newStack.printStack();
			// // newStack.push(100);
			// newStack.pop();
			// newStack.printStack();
			// newStack.push(1);
			// newStack.printStack();
			// for(var i = 0; i < 100; i++){
			// 	newStack.push(i);
			// }
			// // newStack.printFullStack();
			// newStack.printStack();
			// // Page63Node<int> reversed_stack = newStack.reverse();
			// // reversed_stack.printFullStack();
			// newStack.m_reverse();
			// newStack.printFullStack();
			
		}
		// private static void PrintStudentMethod()
		// {
		// 	Singleton fromEmployee = Singleton.GetInstance;
		// 	fromEmployee.PrintDetails("From Employee.");
		// }
		// private static void PrintEmployeeDetails()
		// {
		// 	Singleton fromStudent = Singleton.GetInstance;
		// 	fromStudent.PrintDetails("From Student.");
		// }

		// private static void TestMergeSort()
		// {
		// 	int[] numbers = { 2, 3, 3, 1, 5, 10, 5000, 512, 12, 11, 15, 0, 22, 55, 101 };

		// 	foreach (int number in numbers)
		// 	{
		// 		Console.WriteLine("Before " + number);
		// 	}
		// 	MergeSorter.DoMergeSort(numbers);

		// 	foreach (int number in numbers)
		// 	{
		// 		Console.WriteLine("After " + number);
		// 	}
		// }

		// private void button1_Click(object sender, EventArgs e)
		// {
		// 	Random rnd = new Random();
		// 	int num;
		// 	lbArray1.Text = "";
		// }
    }
}
