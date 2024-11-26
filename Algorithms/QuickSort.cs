namespace Algorithms
{
	public static class Sorting
	{
		public static void QuickSort<T>(T[] array) where T : IComparable<T>
		{
			QuickSortRecursion(array, 0, array.Length - 1);
		}

		private static void QuickSortRecursion<T>(T[] array, int left, int right) where T : IComparable<T>
		{
			if (left < right)
			{
				int pivotIndex = Partition(array, left, right);
				QuickSortRecursion(array, left, pivotIndex - 1);
				QuickSortRecursion(array, pivotIndex + 1, right);
			}
		}

		private static int Partition<T>(T[] array, int left, int right) where T : IComparable<T>
		{
			T pivot = array[right];
			int i = left - 1;

			for (int j = left; j < right; j++)
			{
				if (array[j].CompareTo(pivot) <= 0)
				{
					i++;
					(array[i], array[j]) = (array[j], array[i]);
				}
			}

			(array[i + 1], array[right]) = (array[right], array[i + 1]);
			return i + 1;
		}
	}
}