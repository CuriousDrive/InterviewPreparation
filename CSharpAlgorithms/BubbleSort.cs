using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithms
{
    public class BubbleSort
    {
        static void Main()
        {
            int[] numbers = new int[] { 33, 56, 12, 78, 23, 90, 34, 89, 45, 67, 35 };
            Console.WriteLine(String.Join(" ",Sort(numbers)));
        }

        private static int[] Sort(int[] numbers)
        {
            for(int i =0; i < numbers.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if(numbers[i] < numbers[j])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
