using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Produkt
    {
        public string nazwa;
        public double cena;
        public string opis;
        public void getNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
        public void getcena(double acena)
        {
            this.cena=acena;
        }
        public void getOpis(string aopis)
        {
            this.opis = aopis;
        }
        public void produkt(string anazwa, double acena, string aopis)
        {
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }
        
    }

    class Profil
    {
        public string imie;
        public string drugieImie;
        public string nazwisko;
        public void getImie()
        {
            Console.WriteLine("imie?");
        }
        public void getNazwisko()
        {
            Console.WriteLine("nazwisko?");
        }
    }

    class Uzytkownik
    {
        public string login;
        public string haslo;
        public Profil profil;
        public void loguj()
        {
            Console.WriteLine("loguj?");
        }
        public Uzytkownik(Profil imie)
        {
            profil = imie;
        }
    }

    class Koszyk
    {
        public int id;
        public Produkt produkt;
        public Uzytkownik uzytkownik;
        public int getId()
        {
            return id;
        }
        public void operation()
        {
            
        }
        public Koszyk(Produkt nazwa)
        {
            produkt = nazwa;
        }
        public void setUzytkownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
    }


    internal class Program
        {
        static void Main(string[] args)
        {
            Profil prof = new Profil();
            Produkt prod = new Produkt();
            Uzytkownik user = new Uzytkownik(prof);
            Koszyk kosz = new Koszyk(prod);

        }
    }
}
