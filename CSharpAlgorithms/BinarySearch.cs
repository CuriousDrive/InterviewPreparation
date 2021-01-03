using System;
using System.Collections.Generic;

namespace CSharpAlgorithms
{
    class BinarySearch
    {
        static void Main2(string[] args)
        {
            //implemeting binary search
            int[] sortedArray = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150 };
            int position = BinarySearchIterative(sortedArray, 70);
            position = BinarySeachRecursive(sortedArray, 150, 0, sortedArray.Length - 1);

            Console.Write(position);
        }

        public static int BinarySearchIterative(int[] sortedArray, int searchNumber)
        {
            //10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110
            int min = 0;
            int max = sortedArray.Length - 1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if (sortedArray[mid] == searchNumber)
                {
                    return mid;
                }
                else if (sortedArray[mid] > searchNumber)
                {
                    max = mid - 1;
                }
                else if (sortedArray[mid] < searchNumber)
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        public static int BinarySeachRecursive(int[] sortedArray, int searchNumber, int min, int max)
        {
            if(min > max)
            {
                return -1;
            }
            else
            {
                int mid = (min + max) / 2;
                if(sortedArray[mid] == searchNumber)
                {
                    return mid;
                }
                else if(sortedArray[mid] > searchNumber)
                {
                    return BinarySeachRecursive(sortedArray, searchNumber, min, mid - 1);
                }
                else if (sortedArray[mid] < searchNumber)
                {
                    return BinarySeachRecursive(sortedArray, searchNumber, mid + 1, max);
                }
            }
            return -1;
        }

    }
}
