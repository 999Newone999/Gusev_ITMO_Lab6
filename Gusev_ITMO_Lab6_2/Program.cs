using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string sMod = "";
            bool polindromYes = false;

            Console.WriteLine("Введите предложение:");
            s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) != " ")
                {
                    sMod += s.Substring(i, 1).ToUpper();
                }
            }
            for (int j = 0; j < sMod.Length; j++)
            {
                if (sMod.Substring(j, 1) == sMod.Substring((sMod.Length - j-1), 1))
                {
                    polindromYes = true;
                }
                else
                {
                    polindromYes = false;
                    break;
                }
            }
            if (polindromYes)
            {
                Console.WriteLine("\"{0}\" - полиндром", s);
            }
            else
            {
                Console.WriteLine("\"{0}\" - не полиндром", s);
            }
            Console.ReadKey();
        }
    }
}
