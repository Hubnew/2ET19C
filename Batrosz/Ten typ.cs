using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static int zad1(int a, int b)
        {
            int suma = 0;
            for (int i = a; i <= b; i++)
            {
                suma += i;
            }
            return suma;
        }
        static void Main(string[] args)
        {
            //zad1
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int suma = 0;
            suma = zad1(a,b);
            Console.WriteLine(suma);*/
            //zad2
            /*string odp = "t";
            int sumauje = 0;
            int sumadod = 0;
            while (odp == "t")
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    sumauje += a;
                }
                else if (a > 0)
                {
                    sumadod += a;
                }
                else
                {
                    odp = "n";
                }
            }*/
            //zad3
            /*int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Liczba nie jest parzysta");
            }
            if (n % 2 == 1)
            {
                for(int i = 1; i <= n; i += 2)
                {
                    Console.WriteLine(i + " ");
                }
            }*/
            //zad4
            /*int n = int.Parse(Console.ReadLine());
            for(int i = 2; i <= n; i *= 2)
            {
                Console.WriteLine(i + " ");
            }*/
            //zad5
            int suma = 0;
            int sumal = 0;
            int sredia = 0;
            int a = 1;
            int i = 1;
            int najw = a;
            int najm = a;
            while(a!=0)
            {
                Console.WriteLine("dej liczbę całkowitą: ");
                a = int.Parse(Console.ReadLine());
                if (najm >= a) najm = a;
                if (najw <= a) najw = a;
                suma += a;
                i++;
            }
            sumal = najw + najm;
            sredia = suma / i;
            Console.WriteLine($"suma = {suma} średnia = {sredia}");
        }
    }
}
