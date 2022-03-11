using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            string sMod;
            int count = 0;
            int countDeleted = 0;
            bool countOk = false;

            Console.WriteLine("Введите предложение:");
            s = Console.ReadLine();
            sMod = s;
            for (int i = 0; i < s.Length; i++)
            {
                if ((s.Substring(i, 1) == "{")&&(countOk == false))
                {
                    countOk = true;
                    count=1;
                }
                else if ((s.Substring(i, 1) == "{") && (countOk == true))
                {
                    count = 1;
                }
                else if ((s.Substring(i, 1) == "}") && (countOk == true))
                {
                    countDeleted += count;
                    sMod= sMod.Remove(i - countDeleted, count+1);
                    countDeleted++;
                    countOk = false;
                }
                else if ((s.Substring(i, 1) != "{") && (countOk == true))
                {
                count++;
                }

            }
            Console.WriteLine(sMod);
            Console.ReadKey();
        }
    }
}
