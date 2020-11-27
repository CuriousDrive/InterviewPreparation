using System;
using System.Collections.Generic;
using System.Linq;

/*
You are building an educational website and want to create a simple calculator for students to use. The calculator will only allow addition and subtraction of non-negative integers.

Given an expression string using the "+" and "-" operators like "5+16-2", write a function to find the total.

Sample input/output:
calculate("6+9-12")  => 3
calculate("1+2-3+4-5+6-7") => -2
calculate("100+200+300") => 600
calculate("1-2-3-0") => -4
calculate("255") => 255

n: length of the input string

*/

class Solution
{

    static void Main(String[] args)
    {

        // 10-1+2+3
        // "10","1+2+3"
        //10 + "-1" +"2" + "3"       

        //string expression1 = "6+9-12"; // = 3
        //string expression2 = "1+2-3+4-5+6-7"; // = -2
        //"1+2", "3+4", "5+6", "7"
        // ("1" , "2") ,("-3","4"), ("-5", "6") ("-7")
        // 3, 1
        //string expression3 = "100+200+300"; // = 600
        string expression4 = "1-2-3-0"; // = -4
        //string expression5 = "255"; // = 255

        Console.WriteLine(Calculate(expression4));

    }

    public static int Calculate(string expression)
    {
        int result = 0;
        string[] minusExpression = expression.Split('-');

        // minusExpression = "1+2", "3+4", "5+6", "7"
        for (int i = 0; i < minusExpression.Length; i++)
        {
            string[] sumExpression = minusExpression[i].Split('+');

            //sumExpression = "1" , "2"
            //sumExpression = "-3", 5

            for (int j = 0; j < sumExpression.Length; j++)
            {
                if (i > 0 && j == 0)
                {
                    result -= Convert.ToInt32(sumExpression[j]);    
                }
                else
                    result += Convert.ToInt32(sumExpression[j]);
            }
        }

        return result;
    }



}
