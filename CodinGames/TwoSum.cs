using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        //3, 1, 5, 7, 5, 9
        //3, 1, 5, 7, 5, 9
        for (int i =0; i < list.Count(); i++)
        {
            for (int j = 0; j < list.Count(); j++)
            {
                if(list[i] + list[j] == sum && i != j)
                {
                    return new Tuple<int, int>(i, j);
                }
            }
        }
        return null;
    }

    public static void Main3(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}