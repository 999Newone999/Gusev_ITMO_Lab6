using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int wordMaxLength =0;
            Console.WriteLine("Введите предложение:");
            s = Console.ReadLine();
            string[] stringMassive;
            stringMassive = s.Split();
            string stringWord ="";

            foreach (string str in stringMassive)
            { 
                if (str.Length>wordMaxLength)
                {
                    wordMaxLength = str.Length;
                    stringWord = str;
                }
            }
            Console.WriteLine("Самое длинное слово: {0}", stringWord);
            Console.ReadKey();
        }
    }
}
