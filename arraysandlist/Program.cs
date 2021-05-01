using System;
using System.Collections.Generic;

namespace arraysandlist
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            var names = new List<string>();
            while(true)
            {
                var c = names.Count;
                Console.WriteLine("Enter the name ");
                var str = Console.ReadLine();
                names.Add(str);
                foreach(var name in names)
                {
                    Console.Write(name);
                    Console.Write(" ");
                }

                if (str == "")
                    break;
                if(c>2)
                {
                    var val = c - 2;
                    Console.Write("And {0}",val);
                    Console.Write(" ");
                }
                Console.Write("Liked your post");
                Console.WriteLine();
            }
            /*
            /*
            // question 2 solution
            var ar1 = new string[1];
            ar1[0] = Console.ReadLine();
            var ar2 = new char[10];
            string str = ar1[0];
            var n = str.Length;
            for(int i =0;i<n;i++)
            {
                ar2[n - 1 - i] = str[i];
            }
            var ar3 = new string(ar2);

            //Array.Reverse(ar1);
            Console.WriteLine(ar3);
            */
            /*
            // Question 3 : solved
            ar:
                while (true)
                {
                    var str = new string[5];
                    for (int j = 0; j < 5; j++)
                    {
                        str[j] = Console.ReadLine();
                    }
                    int value;
                    int i;
                    for (i = 0; i < 5; i++)
                    {
                        if (int.TryParse(str[i], out value))
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("please renter the numbers");
                            break;
                        }

                    }
                    if (i < 4)
                    {
                        goto ar;
                    }
                    int[] ints = Array.ConvertAll(str, s => int.Parse(s));
                    Array.Sort(ints);
                    Console.WriteLine();
                    foreach(var mem in ints)
                    {

                        Console.Write(mem);
                    }
                    break;

                }
            */

        }
    }
}
