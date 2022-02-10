using System;
using System.Collections.Generic;
/*
 * Test your Knowledge
 * 1.When to use String vs. StringBuilder in C# ?
 * 
 * 2.What is the base class for all arrays in C#?
 * 
 * 3.How do you sort an array in C#?
 * 
 * 4.What property of an array object can be used to get the total number of elements in an array?
 * 
 * 5.Can you store multiple data types in System.Array?
 * 
 * 6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
 * 
 */

namespace ArraysAndStrings
{
    class MainClass
    {
        static String parsesURL(string server, string resource = "", string protocol = "")
        {
            if (protocol == "" && resource != "") 
            {
                return server + "/" + resource;
            }
            else if (protocol == "" && resource == "") 
                return server;
            }
            else if (protocol != "" && resource == "") 
            {
                return protocol + "://" + server;
            }

            return protocol + "://" + server + "/" + resource;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1/");
            Console.WriteLine("Input");
            string sample = Console.ReadLine();
            char[] charArray = sample.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new String(charArray));
            Console.WriteLine();
            Console.WriteLine("2/");
            List<char> q = new List<char>();
            Console.WriteLine("Input");
            string sample1 = Console.ReadLine();
            string[] words = sample1.Split('.', ' ', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ',');
            for (int i = 0; i < sample1.Length; i++)
            {
                if (sample1[i].Equals('.') || sample1[i].Equals(':') || sample1[i].Equals(';') || sample1[i].Equals('=') || sample1[i].Equals('(') || sample1[i].Equals(')') || sample1[i].Equals('&') || sample1[i].Equals('[') || sample1[i].Equals(']') || sample1[i].Equals('\"') || sample1[i].Equals('\'') || sample1[i].Equals('\\') || sample1[i].Equals('/') || sample1[i].Equals('!') || sample1[i].Equals('?') || sample1[i].Equals(','))
                {
                    q.Add(sample1[i]);
                }

            }


            int start = 0;
            int end = words.Length - 1;
            while (start < end)
            {
                if (String.IsNullOrWhiteSpace(words[start]))
                {
                    start += 1;
                }
                if (String.IsNullOrWhiteSpace(words[end]))
                {
                    end -= 1;
                }
                if (!String.IsNullOrWhiteSpace(words[start]) && !String.IsNullOrWhiteSpace(words[end]))
                {
                    string temp = words[start];
                    words[start] = words[end];
                    words[end] = temp;
                    start += 1;
                    end -= 1;
                }
            }
            string result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(words[i]))
                {
                    words[i] = q[0].ToString();
                    q.RemoveAt(0);
                }
            }
            result = String.Join(" ", words);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine("3/");
            string sample2 = Console.ReadLine();
            string[] words2 = sample2.Split('.', ' ', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ',');
            for (int i = 0; i < words2.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(words2[i]))
                {
                    int begin = 0;
                    int last = words2[i].Length - 1;
                    bool isPalindromes = true;
                    while (begin < last)
                    {
                        if (!words2[i][begin].Equals(words2[i][last]))
                        {
                            isPalindromes = false;
                            break;
                        }
                        begin++;
                        last--;
                    }
                    if (isPalindromes)
                    {
                        Console.WriteLine(words2[i]);
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("4/");
            Console.WriteLine(parsesURL(server: "www.apple.com", protocol: "https", resource: "iphone"));
        }
    }
}
