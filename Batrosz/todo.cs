using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad 1 - Medium - Oblicz sumę n pierwszych liczb trzycyfrowych

            /*            int n = int.Parse(Console.ReadLine());
                        int sum = 0;
                        for(int i = 100; i < n + 100; i++)
                        {
                            sum +=i;
                        }*/
            //Console.WriteLine(sum);
            //zad 2 - Light Hard - Napis sumę k początkowych liczb fibonacciego
            /*            int fibo = 0;
                        int b = 1;
                        int a = 0;
                        int k = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= k; i++)
                        {
                            fibo = b;
                            b = b + a;
                            a = fibo;
                        }
                        Console.WriteLine(fibo);*/

            //zad 3 - Light Hard - Sprawdzenie liczby doskonałej n bez jej samej
            /*            int n = int.Parse(Console.ReadLine());
                        int suma = 0;
                        for (int i = 0; i < n; i++)
                        {
                            if (n % i == 0)
                            {
                                suma = suma + i;
                            }
                        }
                        if (n == suma)
                        {
                            Console.WriteLine("Jest doskonała");
                        }
                        else
                        {
                            Console.WriteLine("Nie jest");
                        }*/
            //zad 4 - medium - Znajdź sumę ciągu:
            //a) 3+6+12+24+48..
            //b)1+4+7+10+13..
            //c)5-10+20-40+80..
            //a)
            /*            int n =int.Parse(Console.ReadLine());
                        int suma = 3;
                        int temp = suma;
                        for(int i = 0; i < n-1; i++)
                        {
                            temp = temp * 2;
                            suma = suma + temp;
                        }
                        Console.WriteLine(suma);*/
            //b)
            /*            int n = int.Parse(Console.ReadLine());
                        int suma = 1;
                        int temp = suma;
                        for (int i = 0; i < n - 1; i++)
                        {
                            temp = temp +3;
                            suma = suma + temp;
                        }
                        Console.WriteLine(suma);*/

            //c)
            int n = int.Parse(Console.ReadLine());
            int suma = 5;
            int temp = suma;
            for (int i = 0; i < n - 1; i++)
            {
                temp = temp * 2;
                for(int j = 0; j < n-1; j++)
                {
                    if(j%n==0) suma = suma - temp;
                    else suma = suma + temp;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
