using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool zad1(int a, int b)
        {
            if ((a + b) % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool zad2(float a, float g)
        {
            float ar = (a + g) /2;
            float geo = ((float)Math.Sqrt(a*g));
            if (ar > geo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool zad3(int k, int l, int m)
        {
            if (k == l)
            {
                return true;
            }
            else if (k == m)
            {
                return true;
            }
            else if (l == m)
            {
                return true;
            }
            else if (l == k)
            {
                return true;
            }
            else if (m == k)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int zad4(int a, int b, int c, int d)
        {
            if (a == b || a == c || a == d || b == c || c == d || b == d)
            {
                Console.WriteLine("podano błędne wartości ");
            }
            else
            {
                if (a < b && a < c && a < d)
                {
                    return a;
                }
                else if (a > b && a < c && a < d)
                {
                    return b;
                }
                else if (a < b && a > c && a < d)
                {
                    return c;
                }
                else if (d < a && d < b && d < c)
                {
                    return d;
                }
            }
        }
        static void Main(string[] args)
        {
            /*    zad1 
             *    Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą
             *    int a = int.Parse(Console.ReadLine());
                        int b = int.Parse(Console.ReadLine());
                        if (zad1(a, b))
                        {
                            Console.WriteLine("tak jest");
                        }
                        else
                        {
                            Console.WriteLine("nie jest");
                        }*/
            /*          zad2
                        Sprawdź, czy średnia arytmetyczna dwóch wpisanych liczb jest wieksza od jej średniej geometrycznej.
                        int a = int.Parse(Console.ReadLine());
                        int g = int.Parse(Console.ReadLine());
                        if (zad2(a, g))
                        {
                            Console.WriteLine($"Tak jest");
                        }
                        else
                        {
                            Console.WriteLine($"Nie jest");
                        }*/
            /*            int k = int.Parse(Console.ReadLine());
                        int l = int.Parse(Console.ReadLine());
                        int m = int.Parse(Console.ReadLine());
                        if (zad3(k, l, m))
                        {
                            Console.WriteLine($"Tak zmienne rowne to {k} oraz {l}");
                        }
                        else if(zad3(k, l, m))
                        {
                            Console.WriteLine($"Tak zmienne rowne to {k} oraz {m}");
                        }
                        else if(zad3(k, l, m))
                        {
                            Console.WriteLine($"Tak zmienne rowne to {l} oraz {m}");
                        }
                        else if (zad3(k, l, m))
                        {
                            Console.WriteLine($"Tak zmienne rowne to {l} oraz {k}");
                        }
                        else if (zad3(k, l, m))
                        {
                            Console.WriteLine($"Tak zmienne rowne to {m} oraz {k}");
                        }
                        else
                        {
                            Console.WriteLine("Nie");
                        }
                        Console.ReadLine();*/
            Console.Write("Podaj pierwszą liczbę: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Podaj trzecią liczbę: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Podaj czwartą liczbę: ");
            int d = int.Parse(Console.ReadLine());

            zad4(a, b, c, d);  
        }
    }
}
