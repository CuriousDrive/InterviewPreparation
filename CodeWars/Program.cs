using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Extract(new int[] { -3, -2, -1, 2, 10, 15, 16, 18, 19, 20 }));
        }

        /*
            individual integers
            or a range of integers denoted by the starting integer separated from the end integer 
            in the range by a dash, '-'. 
            The range includes all integers in the interval including both endpoints. 
            It is not considered a range unless it spans at least 3 numbers. For example ("12, 13, 15-17")
            solution([-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
            // returns "-6,-3-1,3-5,7-11,14,15,17-20"
         */
        public static string Extract(int[] args)
        {
            //-6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20
            string finalString = string.Empty;
            string firstNumber = string.Empty;
            string lastNumber = string.Empty;

            for (int i = 0; i < args.Length; i++)
            {
                if (i == args.Length - 1)
                {
                    if (firstNumber == string.Empty && lastNumber == string.Empty)
                        finalString += Convert.ToString(args[i]);
                    else
                    {
                        if (Convert.ToInt32(lastNumber) > 0)
                            finalString += firstNumber + "-" + lastNumber;
                        else
                            finalString += firstNumber + lastNumber;
                        firstNumber = string.Empty;
                        lastNumber = string.Empty;
                    }
                    continue;
                }
                
                if (args[i] - args[i + 1] != -1)
                {
                    if (firstNumber == string.Empty && lastNumber == string.Empty)
                        finalString += Convert.ToString(args[i]) + ",";
                    else
                    {
                        if(Convert.ToInt32(lastNumber) > 0)
                            finalString += firstNumber + "-" + lastNumber + ",";
                        else
                            finalString += firstNumber + lastNumber + ",";
                        firstNumber = string.Empty;
                        lastNumber = string.Empty;
                    }
                }
                else
                {
                    if(firstNumber == string.Empty)
                        firstNumber = Convert.ToString(args[i]);
                    lastNumber = Convert.ToString(args[i+1]);
                }
            }
            return finalString;
        }

        /*
            nextSmaller(21) == 12
            nextSmaller(531) == 513
            nextSmaller(2071) == 2017
         */
        public static long NextSmaller(long n)
        {
            string numberString = new string(n.ToString().OrderBy(s => s).ToArray());
            for (long i = n-1; i >= 0; i--)
            {
                if (i.ToString().Any(s => !numberString.Contains(s)))
                    continue;

                string nextSmallerNumberString = new string(i.ToString().OrderBy(s => s).ToArray());
                if (numberString == nextSmallerNumberString)
                    return i;
            }
            return -1;
        }

        /*
            Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
            HH = hours, padded to 2 digits, range: 00 - 99
            MM = minutes, padded to 2 digits, range: 00 - 59
            SS = seconds, padded to 2 digits, range: 00 - 59
            The maximum time never exceeds 359999 (99:59:59)
            You can find some examples in the test fixtures.
         */
        public static string GetReadableTime(int seconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            int totalMinutes = t.Minutes;
            int totalHours = t.Hours;

            int remainderMinutes = t.Minutes;
            int remainderSeconds = t.Seconds;

            string totalHoursString = "";
            string remainderMinutesString = "";
            string remainderSecondString = "";

            if (totalHours < 9)
                totalHoursString = $"0{totalHours}";
            else
                totalHoursString = $"{totalHours}";
            if (remainderMinutes < 9)
                remainderMinutesString = $"0{remainderMinutes}";
            else
                remainderMinutesString = $"{remainderMinutes}";
            if (remainderSeconds < 9)
                remainderSecondString = $"0{remainderSeconds}";
            else
                remainderSecondString = $"{remainderSeconds}";

            return $"{totalHoursString}:{remainderMinutesString}:{remainderSecondString}";
        }

        /*
            Complete the function scramble(str1, str2) that returns true if a portion of str1 characters 
            can be rearranged to match str2, otherwise returns false.
         */
        public static bool Scramble(string str1, string str2)
        {

            char[] charMainString = str2.ToCharArray();
            char[] charRearrangedString = str1.ToCharArray();

            for (int i = 0; i < charMainString.Length; i++)
            {
                if (charRearrangedString.Contains(charMainString[i]))
                {
                    int index = Array.IndexOf(charRearrangedString, charMainString[i]);
                    charRearrangedString[index] = new char();
                }
                else
                    return false;
            }
            return true;
        }


        /*
            Given the string representations of two integers, 
            return the string representation of the sum of those integers.
            sumStrings('1','2') // => '3'
         */
        public static string sumStrings(string a, string b)
        {
            return (Convert.ToDecimal(a) + Convert.ToDecimal(b)).ToString();
        }


        /*
            Write a program that will calculate the number of trailing zeros in a factorial of a given number.
            N! = 1 * 2 * 3 * ... * N
            Be careful 1000! has 2568 digits...
         */
        public static int TrailingZeros(int n)
        {
            int fives = 0;
            for (int i = 5; i <= n; i *= 5)
                fives += n / i;

            return fives;
        }

        /*
            Any digit followed by all zeros: 100, 90000
            Every digit is the same number: 1111
            The digits are sequential, incementing†: 1234
            The digits are sequential, decrementing‡: 4321
            The digits are a palindrome: 1221 or 73837
            The digits match one of the values in the awesomePhrases array
         */
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            //decrementing order
            //4321 => 2
            //4325 => 0

            char[] charArrayPerfectNumber = number.ToString().ToArray();
            char[] charArrayOnePlusNumber = (number+1).ToString().ToArray();
            char[] charArrayTwoPlusNumber = (number+2).ToString().ToArray();
            bool isDecrementingPerfectNumber = false;
            bool isDecrementingOnePlus = false;
            bool isDecrementingTwoPlus = false;
            
            for (int i = 1; i <= charArrayPerfectNumber.Length; i++)
            {
                if (i == charArrayPerfectNumber.Length)
                    break;

                if (charArrayPerfectNumber[i - 1] - charArrayPerfectNumber[i] == 1)
                    isDecrementingPerfectNumber = true;
                else
                    isDecrementingPerfectNumber = false;
            }

            for (int i = 1; i <= charArrayOnePlusNumber.Length; i++)
            {
                if (i == charArrayOnePlusNumber.Length)
                    break;

                if (charArrayOnePlusNumber[i - 1] - charArrayOnePlusNumber[i] == 1)
                    isDecrementingOnePlus = true;
                else
                    isDecrementingOnePlus = false;
            }

            for (int i = 1; i <= charArrayTwoPlusNumber.Length; i++)
            {
                if (i == charArrayTwoPlusNumber.Length)
                    break;

                if (charArrayTwoPlusNumber[i - 1] - charArrayTwoPlusNumber[i] == 1)
                    isDecrementingTwoPlus = true;
                else
                    isDecrementingTwoPlus = false;
            }

            if (isDecrementingPerfectNumber)
                return 2;

            if (isDecrementingOnePlus || isDecrementingTwoPlus)
                return 1;

            //check if palindrome
            string perfectPalindrome = new string(number.ToString().Reverse().ToArray());
            string onePlusPalindrome = new string((number + 1).ToString().Reverse().ToArray());
            string twoPlusPalindrome = new string((number + 2).ToString().Reverse().ToArray());

            if (number == Convert.ToInt32(perfectPalindrome))
                return 2;

            if ((number + 1) == Convert.ToInt32(onePlusPalindrome) || (number + 2) == Convert.ToInt32(twoPlusPalindrome))
                return 1;

            //awesome phrases
            if (awesomePhrases.Contains(number))
                return 2;

            if (awesomePhrases.Contains(number + 1) || awesomePhrases.Contains(number + 2))
                return 1;

            return 0;
        }

        /*
            Create a function that takes a positive integer and returns the next bigger number that can be formed by rearranging its digits. 
            For example:
         */
        public static long NextBiggerNumber(long n)
        {
            //code me
            return Convert.ToInt64(new string(n.ToString().OrderByDescending(c => c).ToArray()));
        }
        /*
            Sudoku is a game played on a 9x9 grid. 
            The goal of the game is to fill all cells of the grid with digits from 1 to 9, so that each column, 
            each row, and each of the nine 3x3 sub-grids (also known as blocks) 
            contain all of the digits from 1 to 9.
            (More info at: http://en.wikipedia.org/wiki/Sudoku) 
         */
        public static bool ValidateSolution(int[][] board)
        {
            //TODO
            if (board.Any(innerArray => innerArray.Any(number => number == 0)))
                return false;


            return false;
        }

        /*
            Write an algorithm that takes an array and moves all of the zeros to the end, 
            preserving the order of the other elements.
            Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
         */
        public static int[] MoveZeroes(int[] arr)
        {
            // TODO: Program me
            int[] nonZeroNumber = arr.Where(number => number != 0).ToList().ToArray();
            int[] zeroNumbers = arr.Where(number => number == 0).ToList().ToArray();

            int mainCount = 0;

            for (int i = 0; i < nonZeroNumber.Length; i++)
            {
                arr[mainCount] = nonZeroNumber[i];
                mainCount++;
            }

            for (int i = 0; i < zeroNumbers.Length; i++)
            {
                arr[mainCount] = zeroNumbers[i];
                mainCount++;
            }
            return arr;
        }

        /*
         Write a function that will find all the anagrams of a word from a list. 
         You will be given two inputs a word and an array with words. 
         You should return an array of all the anagrams or an empty array if there are none. 
         For example:
         anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']
         anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']
         anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
         */
        public static List<string> Anagrams(string word, List<string> words)
        {
            word.OrderBy(s => s);
            Console.WriteLine(word);
            return words.Where(wrd => wrd.OrderBy(w => w).ToString() == "").ToList();
        }

        /*
         Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
         Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
         If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
         */

        public static string Order(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }


        public static string Order1(string words)
        {
            if (words == string.Empty)
                return "";

            string result = string.Empty;
            string[] arrWords = words.Split(' ');
            Dictionary<double, string> keyValuePairs = new Dictionary<double, string>();

            for (int i = 0; i < arrWords.Length; i++)
            {
                double intPosition = Char.GetNumericValue(arrWords[i].Where(s => Char.IsDigit(s)).FirstOrDefault());
                keyValuePairs.Add(intPosition, arrWords[i]);
            }

            keyValuePairs.OrderBy(kp => kp.Key);

            for (int i = 1; i <= keyValuePairs.Count(); i++)
            {
                if (i <= keyValuePairs.Count() - 1)
                    result = result + keyValuePairs[i] + " ";
                else
                    result = result + keyValuePairs[i];
            }

            return result;
        }

        /*
         In this kata you are required to, given a string, 
         replace every letter with its position in the alphabet.
         If anything in the text isn't a letter, ignore it and don't return it.
         "a" = 1, "b" = 2, etc.
         */

        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower()
                                                  .Where(c => char.IsLetter(c))
                                                  .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
                                                  .ToArray());
        }

        public static string AlphabetPosition2(string text)
        {
            string allAlphabets = "abcdefghijklmnopqrstuvwxyz";
            text = text.ToLower();

            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (allAlphabets.IndexOf(text[i]) != -1)
                {
                    if (i > 0 && result.Length > 0)
                        result = result + " " + (allAlphabets.IndexOf(text[i]) + 1);
                    else
                        result = (allAlphabets.IndexOf(text[i]) + 1).ToString();
                }

            }

            return result;
        }

        /*
          Write a function that takes an integer as input, 
          and returns the number of bits that are equal to one in the 
          binary representation of that number. You can guarantee that input is non-negative.
          Example: The binary representation of 1234 is 10011010010, 
          so the function should return 5 in this case
         */
        public static int CountBits(int n)
        {
            string binaryNumber = Convert.ToString(n, 2);
            return binaryNumber.Count(bn => bn == '1');
        }

        /*
         Implement the function unique_in_order which takes as argument a sequence 
         and returns a list of items without any elements with the same value next to each other 
         and preserving the original order of elements.
         uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
         uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
         uniqueInOrder([1,2,2,3,3])       == {1,2,3}
         */

        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            //your code here...
            List<T> uniqueInOrder = new List<T>();

            for (int i = 0; i < iterable.Count(); i++)
            {
                T currentItem = iterable.ElementAt(i);
                if (iterable.Count() >= i + 1)
                {
                    T nextItem = iterable.ElementAt(i + 1);

                    if (!currentItem.Equals(nextItem))
                    {
                        uniqueInOrder.Add(currentItem);
                    }
                }
            }

            return uniqueInOrder;
        }


        /*
         The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:
         maxSequence [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        -- should be 6: [4, -1, 2, 1]
        Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. If the list is made up of only negative numbers, return 0 instead.
        Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
         */
        public static int MaxSequence(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i <= j)
                        continue;
                    if (sum < arr[i] + arr[j])
                        sum = arr[i] + arr[j];
                }
            }
            return sum;
        }

        /*
         Given a string of words, you need to find the highest scoring word.
        Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.
        You need to return the highest scoring word as a string.
        If two words score the same, return the word that appears earliest in the original string.
        All letters will be lowercase and all inputs will be valid.
         */
        public static string High(string s)
        {
            char[] charArray = s.ToCharArray();
            return charArray.OrderByDescending(c => c).ToString();
        }

        /*
         he number 89 is the first integer with more than one digit that fulfills the property partially introduced in the title of this kata. What's the use of saying "Eureka"? Because this sum gives the same number.
         In effect: 89 = 8^1 + 9^2
         The next number in having this property is 135.
         See this property again: 135 = 1^1 + 3^2 + 5^3
         We need a function to collect these numbers, that may receive two integers a, b that defines the range [a, b] (inclusive) and outputs a list of the sorted numbers in the range that fulfills the property described above.
         Let's see some cases:
         Comment by : sir_yawnston
         so under the hood, a char is just a 16-bit number representing a Unicode UTF-16 character. every character in UTF-16 corresponds to a single number in a 16-bit integer. 49 is the value which represents the LETTER "1"
         */

        public static long[] SumDigPow(long a, long b)
        {
            List<long> values = new List<long>();
            for (long x = a; x <= b; x++)
            {
                if (x.ToString().Select((c, i) => Math.Pow(Char.GetNumericValue(c), i + 1)).Sum() == x)
                    values.Add(x);
            }
            return values.ToArray();
        }

        public static long[] SumDigPow1(long a, long b)
        {
            // loop from a to b 
            // convert the number into string and then char array
            // loop through char array to check if it satisfies above condition
            // then add that number in a list

            List<long> lstFinalResult = new List<long>();
            for (long i = a; i <= b; i++)
            {
                string number = Convert.ToString(i);
                double afterPower = 0;
                for (int j = 1; j <= number.Length; j++)
                {
                    double x = Char.GetNumericValue(number[j - 1]);
                    double y = (double)j;
                    double result = Math.Pow(x, y);

                    afterPower += result;
                }
                if (afterPower == i)
                    lstFinalResult.Add(i);
            }
            return lstFinalResult.ToArray();
        }

        /*
         You probably know the "like" system from Facebook and other pages. 
         People can "like" blog posts, pictures or other items. 
         We want to create the text that should be displayed next to such an item.    
         Implement a function likes :: [String] -> String, which must take in input array, 
         containing the names of people who like an item. It must return the display 
         text as shown in the examples:
         
         Kata.Likes(new string[0]) => "no one likes this"
         Kata.Likes(new string[] {"Peter"}) => "Peter likes this"
         Kata.Likes(new string[] {"Jacob", "Alex"}) => "Jacob and Alex like this"
         Kata.Likes(new string[] {"Max", "John", "Mark"}) => "Max, John and Mark like this"
         Kata.Likes(new string[] {"Alex", "Jacob", "Mark", "Max"}) => "Alex, Jacob and 2 others like this"
         */

        public static string Likes(string[] names)
        {
            //just another solution
            switch (names.Length)
            {
                case 0: return "no one likes this"; // :(
                case 1: return $"{names[0]} likes this";
                case 2: return $"{names[0]} and {names[1]} like this";
                case 3: return $"{names[0]}, {names[1]} and {names[2]} like this";
                default: return $"{names[0]}, {names[1]} and {names.Length - 2} others like this";
            }
        }

        public static string Likes1(string[] name)
        {
            if (name.Length == 0)
                return "no one likes this";

            if (name.Length == 1)
                return $"{name[0]} likes this";

            if (name.Length == 2)
                return $"{name[0]} and {name[1]} like this";

            if (name.Length == 3)
                return $"{name[0]}, {name[1]} and {name[2]} like this";

            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }

        /*
         Move the first letter of each word to the end of it, 
         then add "ay" to the end of the word. Leave punctuation marks untouched.
         */
        public static string PigIt(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }

        public static string PigIt1(string str)
        {
            List<string> words = new List<string>(str.Split(' '));

            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i] != "!" || words[i] != "?" || words[i] != ".")
                {
                    string firstLetter = (words[i])[0].ToString();
                    words[i] = words[i] + firstLetter;
                    words[i] = words[i] + "ay";
                    words[i] = words[i].Remove(0, 1);
                }
            }
            str = "";
            for (int i = 0; i < words.Count(); i++)
            {
                str = str + words[i];
                if (i < words.Count() - 1)
                {
                    str = str + " ";
                }
            }
            return str;
        }

        /*
         If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.
        Note: If the number is a multiple of both 3 and 5, only count it once. Also, if a number is negative, return 0(for languages that do have them)
         */
        public static int MultipliesNaturalNumber(int value)
        {
            return Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
        }
        public static int MultipliesNaturalNumber1(int value)
        {
            // find all multiply of 3 and 5
            // need to find sum of these numbers
            int number = 0;
            for (int i = 0; i < value; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    number += i;
                }
            }
            return number;
        }

        /*
         You have an array of numbers.
         Your task is to sort ascending odd numbers but even numbers must be on their places.
         Zero isn't an odd number and you don't need to move it. If you have an empty array, you need to return it.
         */
        public static int[] SortArray(int[] array)
        {
            Queue<int> odds = new Queue<int>(array.Where(e => e % 2 == 1).OrderBy(e => e));
            return array.Select(e => e % 2 == 1 ? odds.Dequeue() : e).ToArray();
        }

        public static int[] SortArray1(int[] array)
        {
            // find the position of all odd numbers in the array => position[]
            // while finding create another array those numbers => actual odd numbers[]
            // sort those numbers  
            // then assign those numbers to the positions

            List<int> lstPositions = new List<int>();
            List<int> lstOddNumbers = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    lstPositions.Add(i);
                    lstOddNumbers.Add(array[i]);
                }
            }
            lstOddNumbers.Sort();
            for (int i = 0; i < lstPositions.Count(); i++)
            {
                array[lstPositions[i]] = lstOddNumbers[i];
            }

            return array;
        }

        /*
         Make a program that filters a list of strings and returns a list with only your friends name in it.
         If a name has exactly 4 letters in it, you can be sure that it has to be a friend of yours! Otherwise, you can be sure he's not...
         Ex: Input = ["Ryan", "Kieran", "Jason", "Yous"], Output = ["Ryan", "Yous"]
         for 1st solution I had to add System.Linq namespace
         Note - you can use LINQ on string[] if you add that namespace
         All the lists including string[] implements interface IEnumerable
         */
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            // Good luck!    
            return names.Where(name => name.Length == 4);
        }

        public static IEnumerable<string> FriendOrFoe1(string[] names)
        {
            List<string> friends = new List<string>();
            // Good luck!
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length == 4)
                    friends.Add(names[i]);
            }
            return friends;
        }

        /*  Return the number (count) of vowels in the given string.
            We will consider a, e, i, o, u as vowels for this Kata (but not y).
            The input string will only consist of lower case letters and/or spaces.
         */
        public static int GetVowelCount(string str)
        {
            return str.Count(i => "aeiou".Contains(i));
        }

        public static int GetVowelCount1(string str)
        {
            int vowelCount = 0;
            // Your code here
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            for (int i = 0; i < vowels.Length; i++)
            {
                vowelCount += str.Split(vowels[i]).Length - 1;
            }
            return vowelCount;
        }

        public static int GetVowelCount2(string str)
        {
            int vowelCount = 0;
            // Your code here
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] arrCharString = str.ToCharArray();

            for (int i = 0; i < arrCharString.Length; i++)
            {
                int vowelInnerCount = 0;
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (vowels[j] == arrCharString[i])
                    {
                        vowelInnerCount++;
                        break;
                    }
                }
                vowelCount += vowelInnerCount;
            }
            return vowelCount;
        }
    }
}
