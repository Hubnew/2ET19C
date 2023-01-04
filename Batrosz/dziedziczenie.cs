using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    class Pojazd
    {
        private string nazwa;
        private int vin;
        public void jedz()
        {
            Console.WriteLine("Jade");
        }
        public void tankuj()
        {
            Console.WriteLine("tankuje");
        }
    }
    class Samochod : Pojazd
    {
        private string oc;
        public void zaparkuj()
        {
            Console.WriteLine("Parmuje");
        }
    }
    class motur : Pojazd 
    { 
        public void zaluzKask()
        {
            Console.WriteLine("ZAKŁADAM");
        }
    }
    class koparka : Pojazd
    {
        private string UDT;
        public void kop()
        {
            Console.WriteLine("Kopie");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //int liczba = 3;
/*            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine($"{i}^2=${i * i}");
            }*/
        }
    }
}
