using System;
using System.Collections.Generic;

namespace Sorting_and_Searching_Algorithms
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			List<int> array = new List<int>();
			array.Add(2);
			array.Add(8);
			array.Add(3);
			array.Add(4);			
			array.Add(100);
			array.Add(5);
			array.Add(7);
			array.Add(6);
			array.Add(1);

			//QuickSort(array, 0, array.Count - 1);
			//PrintList(array);
			//SelectionSort(array);
			//PrintList(array);
			BubbleSort(array);
			PrintList(array);


		}
		public static List<int> SelectionSort(List<int> array){
			
			for (int i = 0; i < array.Count - 1 ; i++)
			{
				int min = i;
				for (int y = i + 1; y < array.Count; y++)
				{
					if (array[min] > array[y])
					{
						min = y;
					}
				}
				int valueOfIndex = array[i];
				array[i] = array[min];
				array[min] = valueOfIndex;
			}
			return array;
		}

		public static List<int> BubbleSort(List<int> array) {
			for (int i = 0; i < array.Count - 1; i++)
			{
				for (int y = 0; y < array.Count  - 1 - i; y++)
				{
					if (array[y] > array[y + 1])
					{
						int value = array[y];
						array[y] = array[y + 1];
						array[y + 1] = value;
					}
				}
			}
			return array;
		}

		public static void QuickSort(List<int> array, int low, int high)
		{
			if (low <= high)
			{
				int i = Partition(array, low, high);
				QuickSort(array, low, i - 1);
				QuickSort(array, i + 1, high);
			}
		}

		private static int Partition(List<int> arr, int low, int high)
		{
			int pivot = arr[high];
			int i = low - 1;

			for (int j = low; j <= high; j++)
			{
				// If current element is smaller than the pivot
				if (arr[j] < pivot)
				{
					i++;    // increment index of smaller element
									// swap arr[i] and arr[j]
					int value1 = arr[j];
					arr[j] = arr[i];
					arr[i] = value1;
				}
			}
			int value = arr[i + 1];
			arr[i + 1] = arr[high];
			arr[high] = value;
			return (i + 1);
		}

		private static void PrintList(List<int> array)
		{
			foreach(int item in array)
			{
				System.Console.WriteLine(item);
			}
		}
	}
	
}