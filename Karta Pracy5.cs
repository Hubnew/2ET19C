using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;

        }
        public static bool kp2z2(int c)
        {
            if (c>=100 && c<1000 && c % 17 == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }
        public static bool kp2z6 (int a,int p)
        {
            if ((Math.Pow(a, p) - a) % p == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine((Math.Pow(i, 3)) + 3 + " ");
            }
            
        }
        public static ArrayList kp3z3(int n) {

            ArrayList alist = new ArrayList();

            for (int i = 1;i < n + 1; i++)
            {
                if (n % i == 0)
                {
                    alist.Add(i);
                }
            }

            return alist;
        }
        static void Main(string[] args)
        {
            //zad 1 kp1z1
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a,b));*/
            //zad 2 kp2z2
            /*int c= int.Parse(Console.ReadLine());
             Console.WriteLine(kp2z2(c));*/
            //zad 3 kp2z6
            /*          int a = int.Parse(Console.ReadLine());
                        int p = int.Parse(Console.ReadLine());
                        if (kp2z6(a, p))
                        {
                            Console.WriteLine("tak spełnia");
                        }
                        else { Console.WriteLine("Nie"); }*/
            //zad 4 kp3z1
            int n = int.Parse(Console.ReadLine());
            kp3z1(n);

            //zad 5 kp3z3

            ArrayList dzialniki = new ArrayList();
            dzialniki = kp3z3(12);

            foreach(int a in dzialniki)
            {
                Console.WriteLine(a+ " ");
            }

        }
    }
}
