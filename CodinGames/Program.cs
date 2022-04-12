using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        //we need to find most recurring substrings in the string
        
        //The substring "string" exists twice => string
        //Peter Piper picked a peck of pickled pepper pipes. => er pipe
        //Is this thing on? => is thi
        //I saw Susie sitting in a shoe shine shop. Where she sits she shines, and where she shines she sits. => where she s
        //Subdermatoglyphic => None
        //Test this test => test

        string text = "The substring string exists twice";

        for (int i = 0; i < text.Length; i++)
        {
            for(int j = 0; j < text.Length; j++)
            {
                if(j-i+1 > 0)
                    Console.WriteLine(text.Substring(i,j-i+1));
            }
        }

    }
}