using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class MainClass
    {
		static void Main(string[] args)
		{
			// TestMergeSort();
			// IsPallindrome.CheckPal("banana");
			// IsPallindrome.CheckPal("BOOOOB");
			// ReverseString.Reverse("Banana");
			Parallel.Invoke(
				() => PrintStudentMethod(),
				() => PrintEmployeeDetails()
			);
			Console.ReadLine();
		}
		private static void PrintStudentMethod()
		{
			Singleton fromEmployee = Singleton.GetInstance;
			fromEmployee.PrintDetails("From Employee.");
		}
		private static void PrintEmployeeDetails()
		{
			Singleton fromStudent = Singleton.GetInstance;
			fromStudent.PrintDetails("From Student.");
		}

		private static void TestMergeSort()
		{
			int[] numbers = { 2, 3, 3, 1, 5, 10, 5000, 512, 12, 11, 15, 0, 22, 55, 101 };

			foreach (int number in numbers)
			{
				Console.WriteLine("Before " + number);
			}
			MergeSorter.DoMergeSort(numbers);

			foreach (int number in numbers)
			{
				Console.WriteLine("After " + number);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			int num;
			lbArray1.Text = "";
		}
    }
}
