using System;
using System.Collections.Generic;
using System.Linq;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        //3, 1, 5, 7, 5, 9 => 10
        for (int i = 0; i < list.Count(); i++)
        {
            if (list[i] > sum)
                continue;
            for(int j = 0; j < list.Count(); j++)
            {
                if(i != j && list[i] + list[j] == sum)
                    return Tuple.Create(i, j);
            }
        }
        return null;
    }

    public static void Main2(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}