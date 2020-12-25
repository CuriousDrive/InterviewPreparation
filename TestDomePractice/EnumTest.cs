using System;

public class Account
{
    [Flags]
    public enum Access
    {
        Modify = 1,
        Submit = 1,

        Delete = 2,
        Publish = 2,
        Comment = 2,

        Writer = 1,
        Editor = 2,

        Owner = 1 | 2
    }

    public static void MainDoNotCall(string[] args)
    {
        Console.WriteLine(Access.Writer.HasFlag(Access.Delete)); //Should print: "False"
    }
}