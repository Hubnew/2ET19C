using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void FirstAndLast(string str)
        {
            int i;

            for (i = 0; i < str.Length; i++)
            {
                if (i == 0)
                    Console.Write(str[i]);

                if (i == str.Length - 1)
                    Console.Write(str[i]);

                if (str[i] == ' ')
                {
                    Console.Write(str[i - 1]
                                    + " "
                                    + str[i + 1]);
                }
            }
        }
        static void Main(string[] args)
        {
            //zad 2
            /*Random ran = new Random();
            for (int i = 0; i < 21; i++)
            {
                int n = ran.Next(1, 20);
                //int n = ran.Next(21, 1000);
                //int n = ran.Next(1001, 1000000);
                //int n = ran.Next(10000001, 10000000);
                if (n % 3 == 1)
                {
                    Console.WriteLine(n);
                }
            }*/
            string str = Console.ReadLine();
            FirstAndLast(str);
        }
    }
}
