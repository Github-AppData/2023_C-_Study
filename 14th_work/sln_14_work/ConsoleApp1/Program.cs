﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate int Compare(int a, int b);
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int [] Dataset, Compare comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for(i = 0; i < Dataset.Length - 1; i++)
            {
                for(j =0; j < Dataset.Length - (i + 1); j++)
                {
                    if(comparer(Dataset[j], Dataset[j + 1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare(AscendCompare));

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} ");
            }

            int[] array2 = { 7, 2, 8, 10, 122 };
            Console.WriteLine("\nSorting descending....");
            BubbleSort(array2, new Compare(DescendCompare));

            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine($"{array2[i]}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
