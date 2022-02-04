using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

namespace PO_Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> test = new List<object>();
            test.Add(1);
            test.Add(2);
            test.Add("aasf");
            test.Add("1");
            test.Add("123");
            test.Add(123);

            List<int> test2 = filterArray(test);
            for(int i = 0; i < test2.Count; i++)
            {
                Console.WriteLine(test2[i]);
            }
            Console.WriteLine("");

            Console.WriteLine(multiplyBy11("9473745364784876253253263723"));


        }

/**
Problem 1. Filter Out Strings from an Array
Create a function that takes an array of non-negative integers and strings and returns a new array without the strings.
Examples
filterArray([1, 2, "a", "b"]) ➞ [1, 2]
filterArray([1, "a", "b", 0, 15]) ➞ [1, 0, 15]
filterArray([1, 2, "aasf", "1", "123", 123]) ➞ [1, 2, 123]
Notes
Zero is a non-negative integer.
The given array only has integers and strings.
Numbers in the array should not repeat.
The original order must be maintained.
**/
        public static List<int> filterArray(List<object> list)
        {
            List<int> re = new List<int>();
            for(int i = 0; i < list.Count; i++)
            {
                int temp = -1;
                if(Int32.TryParse(list[i].ToString(),out temp))
                {
                    bool notIn = true;
                    for(int j = 0; j < re.Count; j++)
                    {
                        if(re[j] == temp)
                        {
                            notIn = false;
                        }
                    }
                    if(notIn)
                    {
                        re.Add(temp);
                    }
                }
            }
            return re;
        }


/**
Problem 2 : Multiply by 11
Given a positive number as a string, multiply the number by 11 and also return it as a string. However, there is a catch:

You are NOT ALLOWED to simply cast the numeric string into an integer!

Now, how is this challenge even possible? Despite this, there is still a way to solve it, and it involves thinking about how someone might multiply by 11 in their head. See the tips below for guidance.
**/
        public static string multiplyBy11(string number)
        {
            string re = number[0] + "";
            number = number + "0";

            for(int i = 0; i < number.Length - 1; i++)
            {
                int sum = Int32.Parse(number[i] + "") + Int32.Parse(number[i + 1] + "");
                if(sum > 9)
                {
                    int ten = Int32.Parse(re[re.Length - 1] + "");
                    re = re.Remove(re.Length - 1, 1);
                    ten++;
                    re = re + ten;
                    re = re + (sum - 10);
                }
                else
                {
                    re = re + sum;
                }
            }
            return re;
        }

/**
3. Logical Reasoning Question:
In this logic question, you are standing in a room with three light switches. The switches all correspond to three different light bulbs in an adjacent room that you cannot see into. With all the light switches starting in the off position, how can you find out which switch connects to which light bulb?

- Turn on both switch 1 and 2
- Wait about 30s to a minute
- Turn off switch 2
- Walk into the other room
- Switch 1 bulb will be on
- Switch 2 bulb will be off but warm
- Switch 3 bulb will be cold
**/


    }
}
