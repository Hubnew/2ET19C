using System;

namespace ConsoleApp1
{
    class trk
    {
        string kolor;
        float b1, b2, b3, h1, pole, obwod;
        public void podajKolor()
        {
            Console.WriteLine("Proszę podać kolor: ");
            kolor = Console.ReadLine();
        }
        public void podajDane()
        {
            Console.WriteLine("Proszę podać pierwszą liczbę: ");
            b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać drugą liczbę: ");
            b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać trzecią liczbę: ");
            b3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać wysokość: ");
            h1 = float.Parse(Console.ReadLine());
        }
        public void obliczObwod()
        {
            obwod = b1 + b2 + b3;
        }
        public void obliczPole()
        {
            pole = b1 * h1 * 2;
        }
        public void wypisz()
        {
            Console.WriteLine($"Kolor {kolor} obwód wynosi {obwod}");
            Console.WriteLine($"Kolor {kolor} pole wynosi {pole}");
        }
    }
    class tra {
        string kolor;
        float b1, b2, b3, b4,h1, pole, obwod;
        public void podajKolor()
        {
            Console.WriteLine("Proszę podać kolor: ");
            kolor = Console.ReadLine();
        }
        public void podajDane()
        {
            Console.WriteLine("Proszę podać pierwszą liczbę: ");
            b1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać drugą liczbę: ");
            b2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać trzecią liczbę: ");
            b3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać czwartą liczbę: ");
            b4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Proszę podać wysokość: ");
            h1 = float.Parse(Console.ReadLine());
        }
        public void obliczObwod()
        {
            obwod = b1 + b2 + b3 + b4;
        }
        public void obliczPole()
        {
            pole = ((b1 + b2) * h1) / 2;
        }
        public void wypisz()
        {
            Console.WriteLine($"Kolor {kolor} obwód wynosi {obwod}");
            Console.WriteLine($"Kolor {kolor} pole wynosi {pole}");
        }
    }
    class kolo
    {
        string kolor;
        double r1, obwod, pole;
        public void podajKolor()
        {
            Console.WriteLine("Proszę podać kolor: ");
            kolor = Console.ReadLine();
        }
        public void podajDane()
        {
            Console.WriteLine("Proszę podać pierwszą liczbę: ");
            r1 = double.Parse(Console.ReadLine());
        }
        public void obliczObwod()
        {
            obwod = 2 * Math.PI * r1;
        }
        public void obliczPole()
        {
            pole = Math.PI * r1 * r1;
        }
        public void wypisz()
        {
            Console.WriteLine($"Kolor {kolor} obwód wynosi {obwod}");
            Console.WriteLine($"Kolor {kolor} pole wynosi {pole}");
        }

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            int odp;
            Console.WriteLine("Prosze wybrać opcję: ");
            Console.WriteLine("1.Trójkąt");
            Console.WriteLine("2.Trapez");
            Console.WriteLine("3.Koło");
            odp = int.Parse(Console.ReadLine());
            if (odp == 1)
            {
                trk Trojkat = new trk();
                Trojkat.podajKolor();
                Trojkat.podajDane();
                Trojkat.obliczObwod();
                Trojkat.obliczPole();
                Trojkat.wypisz();
            }
            if (odp == 2)
            {
                tra Trapez = new tra();
                Trapez.podajKolor();
                Trapez.podajDane();
                Trapez.obliczObwod();
                Trapez.obliczPole();
                Trapez.wypisz();
            }
            if (odp == 3)
            {
                kolo kolo = new kolo();
                kolo.podajKolor();
                kolo.podajDane();
                kolo.obliczObwod();
                kolo.obliczPole();
                kolo.wypisz();
            }
        }
    }
}
