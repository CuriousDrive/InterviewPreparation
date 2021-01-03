using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms
{
    class InsertionSort
    {
        static void Main()
        {
            int[] numbers = new int[] { 33, 56, 12, 78, 23, 90, 34, 89, 45, 67, 35 };
            Console.WriteLine(String.Join(" ", Sort(numbers)));
        }

        private static int[] Sort(int[] numbers)
        {
            //33, 56, 12, 78, 23, 90, 34, 89, 45, 67, 35

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if(numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                        break;
                    }
                }
            }
            return numbers;
        }
    }
}
