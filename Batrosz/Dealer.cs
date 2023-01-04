using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DealerNarkotykow

{

    class Pracownik

    {

        private string imie;

        private string nazwisko;

        private Pracownik przelozony;

        private string pesel;

        public Pracownik(string imie, string anazwisko)
        {
            this.imie = aimie;
            this.nazwisko = anazwisko;
        }
        public Pracownik(string aimie, string anazwisko, string apesel)
        {
            this.imie = aimie;
            this.nazwisko = anazwisko;
            this.pesel = apesel;
        }
        public void pokazSzczegoly()
        {
            System.Console.WriteLine($"{imie},{nazwisko},{pesel} jebać pis");
        }

    }
    class wypozyczenie
    {
        private int id;
        private int nrRefernecyjny;
        private Auto auto;
        private Pracownik opiekun;
        private Klient klient;
        private Pracownik pracownik;
        private Auto auto;

        public Wypozyczenie()
        {

        }
        public Wypozyczenie(int id)
        {

        }
        public Auto wydajAuto()
        {
            System.Console.WriteLine("masz");
        }
        public wypozyczenie(Pracownik apracownik,Auto aAuto){
            this.pracownik = apracownik;
            this.auto = aAuto;
        }
        public setKlient(klient aklient){
            this.klient = aklient;
        }
    }
    class Auto
    {
        private string marka;
        private string model;
        public string rocznik;
        private Dealer dealer;
        private Producent producent;

        public void pokazSzczegoly()
        {

        }
        public static int zlecNaprawe()
        {

        }
        public setProducent(Producent aproducent){
            this.producent = aproducent;
        }
        public setDealer(Dealer adealer){
            this.dealer = adealer;
        }
    }
    class Dealer
    {
        private string nazwa;
        private string miasto;
        private List<Producent> producenci = new List<Producent>();
        private bool strategicznyPartner;


        public Dealer(string anazwa, string amiasto)
        {
            this.nazwa = anazwa;
            this.miasto = amiasto;
        }
        public Dealer(bool astrategicznyPartner)
        {
            this.strategicznyPartner = astrategicznyPartner;
        }
        public void pokazSzczegoly()
        {
            System.Console.WriteLine("jebać pis");
        }
        public void dodajDoListyProducentow(Producent producent){
            producent = nazwa;
            producenci.Add(nazwa);
        }
        public void Aso1(){
            Dealer d1 = new Dealer();
        }

    }
    class Producent
    {
        private string nazwa;
        private int kod;
        private int koncesja;
    }
    class klient{
        private string login;
        private string pass;
        private int id;
        public static List<wypozyczenie> sprawdzHistorie(int id){

        }

        public void Aso(){
            wypozyczenie w1 = new wypozyczenie();
        }
    }

    class Program

    {

        static void Main(string[] args)

        {

            Pracownik p1 = new Pracownik();


        }

    }

}