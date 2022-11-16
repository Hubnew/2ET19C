using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person osoba1 = new Person();
            osoba1.name = "Hubert";
            osoba1.phoneNumber = "000000";
            osoba1.emailAddress = "Nie dla psa";

            osoba1.lives_at = new Address();

            osoba1.lives_at.street = "Lipowa";
            osoba1.lives_at.city = "Poznań";
            osoba1.lives_at.state = "WLKP";
            osoba1.purchaseParkingPass();
            Console.WriteLine(osoba1.lives_at.outputAsLabel());


        }
    }
}
