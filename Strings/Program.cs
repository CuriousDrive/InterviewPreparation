using System;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            string str1 = "123456789";
            char[] temp = new char[8];

            str1.CopyTo(0, temp, 2, str1.Length - 5);
            Console.WriteLine(temp);

            //NOTES

            //Trim - ******************
            // this function trims the whitespaces from the start and end
            // you can also use TrimEnd and TrimStart to just trim start or end

            //string str1 = "   Fahad Mullaji   ";
            //Console.WriteLine(str1);

            //ToCharArray - ******************
            // this function returns the string in char array
            // and you can also get part of char arrya 
            //by passing start index and the length

            //string str1 = "Fahad Mullaji";
            //char[] arrChar = str1.ToCharArray(1,2);

            //foreach (var item in arrChar)
            //Console.Write(item);

            //Substring - ******************
            // this function returns sub string from the start index 
            // which has been passed in the method
            // you can also pass the length of the string that you want back

            //string str1 = "Fahad Mullaji";           
            //Console.WriteLine(str1.Substring(2,2));


            //StartsWith - ******************
            // this function returns True if the 1st char of the string matches 
            // the char which has been passed
            // else it returns False

            //string str1 = "Fahad Mullaji";           
            //Console.WriteLine(str1.StartsWith('<'));


            //Split - ******************
            // this function is used to split the string in array of strings
            // based on the char which has been passed

            //string str1 = "Fahad Mullaji";
            //string[] splitValue = str1.Split(' ');
            //Console.WriteLine(splitValue[1]);

            //Replace - ******************
            // this function replaces the char (1st paramter) in the string
            // with the char (2nd parameter)

            //string str1 = "Fahad Mullaji";  
            //Console.WriteLine(str1.Replace('F', 'M'));

            //Remove - ******************
            // this function removes all the characters from the index which has been passed
            // the 2nd paramter takes the length/count of characters to be removed
            // and if the passed index is out of range then an exception is thrown

            //string str1 = "Fahad Mullaji";
            //Console.WriteLine(str1.Remove(15,2));

            //LastIndexOf - ******************
            // this function returns the last occurence position of the char passed
            // if the char is not found then it returns -1

            //string str1 = "Fahad Mullaji";
            //Console.WriteLine(str1.LastIndexOf("x"));

            //Insert - ******************
            // this function takes index and inserts a string value at that position

            //string str1 = "Mullaji";
            //Console.WriteLine(str1.Insert(4, "Fahad"));

            //ToLower & ToUpper- ******************
            // ToLower => Converts String into lower case based on rules of the current culture
            // ToUpper => Converts String into Upper case based on rules of the current culture

            //string str1 = "Fahad Mullaji";
            //Console.WriteLine(str1.ToLower());

            //IndexOf - ******************
            // this function returns first index position of the char passed
            // if the char is not found then it returns -1

            //string str1 = "Fahad Mullaji";
            //Console.WriteLine(str1.IndexOf('M'));


            //GetType ******************
            // this returns the type name with the namespace
            // index

            //string str1 = "Fahad Mullaji";
            //Console.WriteLine(str1.GetType());

            //Equals ******************
            // this function returns True when the string is exactly the same
            // this is case sensitive

            //string str1 = "Fahad Mullaji";
            //string str2 = "fahad mullaj";
            //Console.WriteLine(str1.Equals(str2));


            //EndsWith ******************
            // this function returns True when the last char of the string
            // matches the char value passed in the function
            // otherwise it returns False

            //string str1 = "Fahad Mullaji";
            //string str2 = "Fahad";
            //Console.WriteLine(str1.EndsWith('j'));

            //Contains ******************
            // this function checks if the string1 contains string2
            // it returns True when string2 is part string1
            // otherwise it returns False

            //string str1 = "Fahad Mullaji";
            //string str2 = "Fahad";
            //Console.WriteLine(str2.Contains(str1));


            //CompareTo - int ******************
            //when 2 integers are same then it returns - 0
            //when number1 is greater than number2 then it returns 1
            //when number1 is less than number2 then it returns -1

            //int number1 = 20;
            //int number2 = 10;
            //Console.WriteLine(number1.CompareTo(number2));


            //CompareTo - string ******************
            //this is used to compare 2 objects like int and string
            //when 2 strings are excatly the same then this returns 0
            //when 2 strings are same but in different cases then it returns 1
            //when 2 strings are of different then it return -1
            //when the string that we comparing is smaller then the main string 
            //then it return 1

            //string name1 = "Fahad Mullaji";
            //string name2 = "fahad mulla";            
            //Console.WriteLine(name1.CompareTo(name2));

            //Clone ******************
            //this is used for making clone of the string

            //string cloneName = (string)name.Clone();
            //Console.WriteLine(name1.CompareTo(name2));
        }
    }
}
