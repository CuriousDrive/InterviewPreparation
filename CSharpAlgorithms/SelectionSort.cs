using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms
{
    public class SelectionSort
    {
        static void Main2()
        {
            int[] numbers = new int[] { 33, 56, 12, 78, 23, 90, 34, 89, 45, 67, 35 };
            Console.WriteLine(String.Join(" ", Sort(numbers)));
        }

        private static int[] Sort(int[] numbers)
        {
            for(int i = 0; i < numbers.Length-1; i++)
            {
                int min_indx = i;
                for(int j = i +1; j < numbers.Length; j++)
                {
                    if (numbers[min_indx] > numbers[j])
                        min_indx = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[min_indx];
                numbers[min_indx] = temp;
            }

            return numbers;
        }
    }
}
