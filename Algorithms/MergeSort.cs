using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
	public static class MergeSorter
	{

		public static int[] DoMergeSort(int[] numbers)
		{
			var sortedNumbers = MergeSortMethod(numbers);

			for (int i = 0; i < sortedNumbers.Length; i++)
				numbers[i] = sortedNumbers[i];

			return numbers;
		}
		private static int[] MergeSortMethod(int[] numbers)
		{
			// Base case
			if (numbers.Length <= 1) return numbers;

			// Need to divide into two arrays! Left and right arrays.
			var left = new List<int>();
			var right = new List<int>();

			Divide(numbers, left, right);

			left = MergeSortList(left);
			right = MergeSortList(right);

			return Merge(left, right);
		}
		private static void Divide(int[] numbers, List<int> left, List<int> right)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				// Odd numbers get added to left.
				if (i % 2 > 0)
					left.Add(numbers[i]);
				// Even numbers get added to right.
				else
					right.Add(numbers[i]);
			}
		}
		private static List<int> MergeSortList(List<int> list)
		{
			return MergeSortMethod(list.ToArray()).ToList();
		}
		private static int[] Merge(List<int> left, List<int> right)
		{
			var result = new List<int>();

			while (NotEmpty(left) && NotEmpty(right))
			{
				if (left.First() <= right.First())
					MoveValueFromSourceToResult(left, result);
				else
					MoveValueFromSourceToResult(right, result);
			}

			MoveRemaining(left, result);
			MoveRemaining(right, result);

			return result.ToArray();
		}

		// Make sure Lists are not empty

		private static bool NotEmpty(List<int> list)
		{
			return list.Count > 0;
		}

		// Move Value from source to result
		private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
		{
			result.Add(list.First());
			list.RemoveAt(0);
		}

		private static void MoveRemaining(List<int> list, List<int> result)
		{
			while (NotEmpty(list))
			{
				MoveValueFromSourceToResult(list, result);
			}
		}
	}
}
