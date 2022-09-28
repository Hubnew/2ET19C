using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            zad1
                        int a, b, wynik;
                        Console.WriteLine("Proszę podać liczbę a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Proszę podać liczbę b: ");
                        b = int.Parse(Console.ReadLine());
                        wynik = (a * a) + (b * b);
                        Console.WriteLine($"{wynik}");*/

            /*zad3*/
            /*            Console.WriteLine("Podaj liczbę: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj liczbę: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj liczbę: ");
                        int c = int.Parse(Console.ReadLine());
                        if (a >= b && b >= c) Console.WriteLine($"{a},{b},{c}");
                        else if (c >= b && b >= a) Console.WriteLine($"{c},{b},{a}");
                        else if (a >= c && c >= b) Console.WriteLine($"{a},{c},{b}");
                        else if (b >= a && a >= c) Console.WriteLine($"{b},{a},{c}");
                        else if (c >= a && a >= b) Console.WriteLine($"{c},{a},{b}");
                        else if (b >= c && c >= a) Console.WriteLine($"{b},{c},{a}");

                        Console.ReadKey();*/

            //zad4
            /*            int a = int.Parse(Console.ReadLine());
                        int c = 1;
                        for (int i = 1; i <= a; i++)
                        {
                            c = c * i;
                        }
                        Console.WriteLine(c);*/
            /*            int x = -7;
                        int b = -7;
                        int a = 1;
            *//*            for (int i = 1; i <= 7; i++)
                        {
                            Console.WriteLine(x);
                            x = x + 4;
                        }*//*

                        while (a <= 7)
                        {
                            Console.WriteLine(b);
                            b = b + 4;
                            a++;

                        }*/
            /*int x = 2;
            int b = 2;
            int a = 1;
            for (int i = 1; i <=6; i++)
            {
                Console.WriteLine(x);
                x = x * 3;
               
            }*/

            /*Console.WriteLine("! ∗ ∗@! ∗ ∗@@! ∗ ∗@@@! ∗ ∗@@@@");*/


            /*            int n = int.Parse(Console.ReadLine());
                        int x = 0;
                        while (n > 0)
                        {
                            n = n / 10;
                            x = x + 1;
                        }
                        Console.WriteLine(x);*/
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("liczba nie jest pierwsza");
                    break;
                }
                else
                {
                    Console.WriteLine("liczba jest pierwsza ");
                    break;
                }
            }

        }
    }
}
