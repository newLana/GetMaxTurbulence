using System;
using System.Linq;
using System.Collections.Generic;

namespace MaxTurbulence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = {5, 5, 5, 4, 7, 5, 10, 5, 9, 9, 9, 10, 11, 12, 12, 13, 10, 7, 5, 10, 5, 9, 6 };
            Console.WriteLine(GetMaxTurbulence(time));
            Console.ReadKey();
        }

        static int GetMaxTurbulence(int[] time)
        {
            List<char> sign = new List<char>();
            for(int i = 0; i < time.Length - 1; i ++)
            {
                if(time[i] > time[i + 1])
                {
                    if (sign.LastOrDefault() == '>')
                    {
                        sign.Add('!');
                    }
                    else 
                    {
                        sign.Add('>');
                    }
                }
                else if(time[i] < time[i + 1])
                {
                    if (sign.LastOrDefault() == '<')
                    {
                        sign.Add('!');
                    }
                    else 
                    {
                        sign.Add('<');
                    }
                }
                else
                {                   
                    sign.Add('!');                   
                }
            }

            return string.Join("", sign).Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(s => s.Length > 1).Max(s => s.Length + 1); 
        }
    }
}
