using System;

namespace ConsoleApp1
{
   class Program
    {
        static int fibo(int n)
        {
            if (n == 0)return 0;
            else if (n == 1) return 1;
            else return fibo(n - 1) + fibo(n - 2);
        }
        static int fibo2(int n)
        {
            return (n <= 2) ? 1 : fibo2(n - 1) + fibo2(n - 2);
        }
        static void Main(string[] args)
        {
            int[] fibon = new int[100];
            int wynik, liczba, opcja;
            Console.WriteLine("Proszę wybrać opcję:");
            Console.WriteLine("1-obliczenie pierwszych n elementów ciągu fibonacciego");
            Console.WriteLine("2-obliczenie n-tego elementu ciagu fibonacciego");
            opcja = int.Parse(Console.ReadLine());
            if (opcja == 1)
            {
                Console.WriteLine("Proszę podać, który element ciągu mam obliczyć:");
                liczba = int.Parse(Console.ReadLine());
                for (int i = 0; i < liczba; i++)
                {
                    fibon[i] = fibo(i);
                    Console.WriteLine($"{i} element ciągu Fibonacciego to: {fibon[i]}");
                }
            }
            if (opcja == 2)
            {
                Console.WriteLine("Prosze podać element ciągu fibonacciego, który chcesz znać");
                liczba = int.Parse(Console.ReadLine());
                wynik = fibo2(liczba);
                Console.WriteLine($"{liczba} wyraz ciągu Fibonacciego to : {wynik}");
            }

        }
    }
}