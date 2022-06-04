using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDomePractice
{
    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            //1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25
            int min = 0;
            int max = sortedArray.Length - 1;
            int mid = 0;
            while(min <= max)
            {
                mid = (min + max) / 2;
                if(sortedArray[mid] == lessThan)
                {
                    return mid;
                }
                else if(sortedArray[mid] > lessThan)
                {
                    max = mid - 1;
                }
                else if(sortedArray[mid] < lessThan)
                {
                    min = mid + 1;
                }
            }
            return mid;
        }

        public static int CountNumbersRecursive(int[] sortedArray, int lessThan, int min, int max, int mid)
        {
            if(min > max)
            {
                return mid+1;
            }
            else
            {
                if(sortedArray[mid] == lessThan)
                {
                    return mid;
                }
                else if(sortedArray[mid] > lessThan)
                {
                    return CountNumbersRecursive(sortedArray, lessThan, min, mid - 1, (min + mid - 1) / 2);
                }
                else if(sortedArray[mid] < lessThan)
                {
                    return CountNumbersRecursive(sortedArray, lessThan, mid + 1, max, (mid + 1 + max) / 2);
                }
            }
            return mid+1;
        }

        public static void Main(string[] args)
        {
            int[] sortedArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25 };
            Console.WriteLine(SortedSearch.CountNumbersRecursive(sortedArray, 7, 0 , sortedArray.Length - 1, (sortedArray.Length - 1)/2));
        }
    }
}
