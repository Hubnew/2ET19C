using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] kwadrat = new double[10, 6];
            int i, j, ileRw;
            Console.Write("Proszę podać ile ma być równań: ");
            ileRw = int.Parse(Console.ReadLine());
            if ((ileRw > 10) && (ileRw < 0))
            {
                Console.WriteLine("Podano za dużą lub za małą liczbę");
            }
            else
            {
                //czytanie
                for (i = 0; i < ileRw; i++)
                {
                    Console.Write($"Równanie Nr. {i + 1} ");
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Proszę podać {j + 1} współczynnik {i + 1} równanie: ");
                        kwadrat[i, j] = double.Parse(Console.ReadLine());
                    }

                }
                //rozwiązywanie
                for (i = 0; i < ileRw; i++)
                {
                    for (j = 0; j < ileRw; j++)
                    {
                        kwadrat[i, 3] = (kwadrat[i, 1] * kwadrat[i, 1]) - (4 * kwadrat[i, 0] * kwadrat[i, 2]);
                        if (kwadrat[i, 3] > 0)
                        {
                            kwadrat[i, 4] = (-kwadrat[i, 1] - Math.Sqrt(kwadrat[i, 3])) / (2 * kwadrat[i, 0]);
                            kwadrat[i, 5] = (-kwadrat[i, 1] + Math.Sqrt(kwadrat[i, 3])) / (2 * kwadrat[i, 0]);
                        }
                        if (kwadrat[i, 3] == 0)
                        {
                            kwadrat[i, 4] = -kwadrat[i, 1] / (2 * kwadrat[i, 0]);
                        }
                        if (kwadrat[i,3] < 0)
                        {
                            Console.Write(" ");
                        }
                    }
                }
                //wypisywanie
                for (i = 0; i < ileRw; i++)
                {
                    if (kwadrat[i, 3] > 0)
                    {
                        Console.WriteLine($"Wynik wynosi {kwadrat[i, 4]} oraz {kwadrat[i, 5]}");
                    }
                    if (kwadrat[i, 3] == 0)
                    {
                        Console.WriteLine($"Wynik wynosi {kwadrat[i, 4]}");
                    }
                    if (kwadrat[i, 3] < 0)
                    {
                        Console.WriteLine("Nie ma rozwiązania");
                    }
                }
            }
        }
    }
}
