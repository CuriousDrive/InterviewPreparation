using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var speedDistances = new List<Tuple<int, int>>();
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int S = int.Parse(inputs[0]);
            int D = int.Parse(inputs[1]);
            speedDistances.Add(Tuple.Create(S,D));
        }

        var time = speedDistances.Select(s => Math.Round((s.Item2 / (float)s.Item1) * 60))
                                    .OrderBy(t => t)
                                    .FirstOrDefault();

        Console.WriteLine(time);
    }
}