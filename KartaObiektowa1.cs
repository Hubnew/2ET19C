using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Rower
{
    private Producent producent;
    private string kolor;
    private Material material;
    public void jedz()
    {
        Console.WriteLine("Wroooom");
    }
    public void setColor(string akolor)
    {
        this.kolor = akolor;
    }
    public string getColor()
    {

    }

    public class Producent
    {
        private string nazwa;
        private string nip;
        public string getNazwa(string anazwa)
        {
            this.nazwa = anazwa;
        }
        public string getNip(string anip)
        {
            this.nip = anip;
        }
        public void setNazwa()
        {

        }
    }
    public class Maretrial
    {
        private string typ;
        private int id;
        private double cena;
        public void setTyp()
        {

        }
        public string getTyp()
        {

        }
        public double getCena()
        {

        }
        public void setID()
        {

        }
    }

    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }