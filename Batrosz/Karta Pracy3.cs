using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* (Easy) Napisz program, który wypisze ciąg sześcianów liczb naturalnych powiększonych o 3
            Wejście: -
            Wyjście: 3, 4, 11...*/

            /*int n;
            Console.WriteLine("Proszę podać liczbę ile mabyć rzeczy: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Math.Pow(i,3)+3);
            }*/

            /*(Easy)Napisz program, który wypisze wszytkie liczby trzycyfrowe podzielne przez 15.
            Wejście: -
            Wyjście: 105, 120, 135...*/

            /*for(int i = 105; i < 1000; i+=15)
            {
                Console.WriteLine(i);
            }*/


            /*Napisz program, który wypisze wszyskie dzielniki podanej liczby n.
            Wejście: p
            Wyjście: dzielniki*/
            /*int n;
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i ++)
            {
                if(n % i == 0 )
                {
                    Console.WriteLine(i);
                }
            }*/

            /*
            (Medium) Napisz program, który obliczy sumę liczb dwucyfrowych.
            Wejście: -
            Wyjście: 4905
            */

            /*int suma, a, b=0;
            Console.WriteLine("Podaj liczbę");
            a=int.Parse(Console.ReadLine());
            for (int i = 10; i < 100; i ++)
            {
                b = b + i;
                i = b;
            }

            Console.WriteLine(b);*/

            /*(Hard) Bajtuś postanowił zrobić dla swoich kolegów pewną zagadkę. Zagadka polega na tym, że koledzy
            najpierw podają liczbę naturalną n. Następnie Bajtuś wybiera sobie liczbę x, taką, że 0 < x < n oraz
            wypisuje n − 1 różnych, mniejszych on n liczb pomijając przy tym swoje tajemnicze x. Napisz program,
            który pozwoli sprawdzić, jaką liczbę x wybrał sobie Bajtuś UwU OwO.*/

            /*            int n = int.Parse(Console.ReadLine());
                        int suma = n * (n + 1) / 2;
                        int liczba;
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Ok daj liczbę {n-1} a ja zgadnę jaka to liczba" );
                        for (int i = 0; i < n-1; i++)
                        {
                            liczba = int.Parse(Console.ReadLine());
                            suma = suma - liczba;
                        }
                        Console.WriteLine($"Wybrałeś {suma}");*/

            int n = int.Parse(Console.ReadLine());
            int x = 1;
            int y = 2;
            int z;
            Console.WriteLine(x);
            for (int i = 1; i < n-2; i++)
            {
                Console.WriteLine(y);
                z = y;
                y = x + y;
                x = z;
            }
        }
    }
}
