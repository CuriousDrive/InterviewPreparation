using System;
using System.Collections.Generic;

public class TrainComposition
{
    LinkedList<int> currentTrain = new LinkedList<int>();
    public void AttachWagonFromLeft(int wagonId)
    {
        currentTrain.AddFirst(wagonId);
    }
    public void AttachWagonFromRight(int wagonId)
    {
        currentTrain.AddLast(wagonId);
    }
    public int DetachWagonFromLeft()
    {
        int firstItem = currentTrain.First.Value;
        currentTrain.RemoveFirst();
        return firstItem;
    }
    public int DetachWagonFromRight()
    {
        int lastItem = currentTrain.Last.Value;
        currentTrain.RemoveLast();
        return lastItem;
    }
    public static void Main2(string[] args)
    {
        TrainComposition train = new TrainComposition();
        train.AttachWagonFromLeft(7);
        train.AttachWagonFromLeft(13);
        Console.WriteLine(train.DetachWagonFromRight()); // 7 
        Console.WriteLine(train.DetachWagonFromLeft()); // 13
    }
}