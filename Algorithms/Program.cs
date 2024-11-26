namespace Algorithms
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char[] charArray = { 'd', 'a', 'f', 'b', 'z', 'm', 'e', 'y' };
			string[] stringArray = { "delta", "alpha", "foxtrot", "bravo", "zulu", "mike", "echo", "yankee" };

			Console.WriteLine("Original char array:");
			PrintArray(charArray);
			Sorting.QuickSort(charArray);
			Console.WriteLine("\nSorted char array:");
			PrintArray(charArray);

			Console.WriteLine("\nOriginal string array:");
			PrintArray(stringArray);
			Sorting.QuickSort(stringArray);
			Console.WriteLine("\nSorted string array:");
			PrintArray(stringArray);
		}

		static void PrintArray<T>(T[] array)
		{
			foreach (T item in array)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();
		}
	}
}
