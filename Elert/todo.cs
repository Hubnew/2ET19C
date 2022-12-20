using System;

namespace ConsoleApp1
{
   class Program
    {
        static void Main(string[] args)
        {
            int tmp = 0, min = 0, ile,tmp2=2;
            Console.WriteLine("Ile ma być liczb? ");
            ile = int.Parse(Console.ReadLine());
            int[] tab1 = new int[ile];
            if (ile<=tmp2)
            {
                Console.WriteLine("Podaj liczby większe lub równe 2");
            }
            else
            {
                for (int i = 0; i < ile; i++)
                {
                    Console.WriteLine($"Proszę podać {i}-tą liczbę: ");
                    tab1[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 2; i <= ile; i++)
                {

                    for (int j = 0; j <= ile; j = i-1)
                    {
                        tmp = tab1[i];
                        if (j >= 1 && tab1[j] > tmp)
                        {
                            tab1[j - 1] = tab1[j];
                            j = j - 1;

                        }
                        else 
                        {
                            tab1[i + 1] = tmp;
                            i++;
                        }
                    }
                }
                Console.WriteLine(tmp);
            }
        }
    }
}