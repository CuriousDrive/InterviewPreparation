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
            //1, 3, 5, 7, 9, 11, 13, 15 , 17, 19
            //1, 3, 5, 7, 9
            //11, 13, 15 , 17, 19
            //-----------------------
            //1, 3, 5, 7

            int splitIndex = sortedArray.Length / 2;
            
            int firstHalfStart = 0;
            int firstHalfEnd = splitIndex-1;
            int secondHalfStart = splitIndex;
            int secondHalfEnd = sortedArray.Length - 1;

            int firstHalfEndNumber = sortedArray[firstHalfEnd];
            int secondHalfStartNumber = sortedArray[secondHalfStart];

            //both numbers are greater
            if(firstHalfEndNumber >= lessThan && secondHalfStartNumber >= lessThan)
            {
                if(firstHalfEndNumber == lessThan)
                {
                    return firstHalfEnd + 1;
                }

                if (secondHalfStartNumber == lessThan)
                {
                    return secondHalfEnd + 1;
                }

                CountNumbers(sortedArray.ToList().Skip(firstHalfEnd + 1).ToArray(), lessThan);
            }

            //one number is greater and another is not 
            //both numbers are smaller
            if ((firstHalfEndNumber <= lessThan && secondHalfStartNumber >= lessThan)
                || (firstHalfEndNumber <= lessThan && secondHalfStartNumber <= lessThan))
            {
                //if (firstHalfEndNumber <= lessThan)
                //{
                //    return firstHalfEnd + 1;
                //}
                if (secondHalfStartNumber >= lessThan)
                {
                    return secondHalfEnd + 1;
                }

                CountNumbers(sortedArray.ToList().Skip(firstHalfEnd + 1).ToArray(), lessThan);
            }
            return 0;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 7));
        }
    }
}
