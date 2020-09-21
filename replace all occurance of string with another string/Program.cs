using System;

namespace replace_all_occurance_of_string_with_another_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Replace("xxxxxforxxxxx xxxx for xxxxx", "xxxxx", "yyyyy"));
        }

        static string Replace(string str, string search, string replace)
        {
            var charArray = str.ToCharArray();
            int length = str.Length;
            int i = 0;
            // loop through end of the string
            while(i < length)
            {
                int j = 0;
                int count = 0;
                // compare each char from the input str and seach str// if matches increment both the count
                while (i< length && j < search.Length && charArray[i++] == search[j++])
                {
                    count++;
                }

                // if the count is same as the searching string means we have found the search string
                // else increment ith position in for loop
                if (count == search.Length)
                {
                    j = i;
                    int k = replace.Length;
                    while (j > 0 && k > 0)
                    {
                        charArray[--j] = replace[--k];
                    }
                }
            }
            return string.Join("",charArray);
        }
    }
}
