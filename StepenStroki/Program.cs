using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            int k;
            k = int.Parse(Console.ReadLine());
            if ((k == 0) || (k > 100001)) 
            {
                Console.WriteLine("NO SOLUTION");               
            }
            else if (k > 0)
            {
                int count = 0;
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        Console.Write(s[j]);
                        count++;
                        if (count == 1023)
                        {
                            return;
                        }
                    }
                }
            }
            else
            {
                k = Math.Abs(k);
                if (s.Length % k != 0)
                {
                    Console.WriteLine("NO SOLUTION");
                    return;
                }
                else
                {
                    int shift = s.Length / k;
                    for (int i = shift; i < s.Length; i++)
                    {
                        if (s[i] != s[i - shift])
                        {
                            Console.WriteLine("NO SOLUTION");
                            return;
                        }
                    }
                    Console.WriteLine(s.Substring(0, shift));
                }

            }
        }
    }
}
