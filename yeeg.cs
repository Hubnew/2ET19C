using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class silnik
    {
        private int pojemnosc;
        private int moc;
        public void start()
        {
            Console.WriteLine("WROOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
        }
        public void stop()
        {
            Console.WriteLine("NIEEEEEEEEE KURWAAAAAAAAAA");
        }
    }
    class radio
    {
        private string model;
        private string typ;

        public void graj()
        {
            Console.WriteLine("ZASYPIAM");
        }
    }

    class auto
    {
        private string kolor;
        private int rok;
        private silnik silnik;
        private radio radio;

        public void jedz()
        {
            Console.WriteLine("jade");
        }
        public void napraw()
        {
            Console.WriteLine("za drogo");
        }
        public void setSilnik(silnik asilnik)
        {
            this.silnik = asilnik;
        }
        public void zamontujRadio(radio aradio)
        {
            this.radio = aradio;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            auto a1 = new auto();
            silnik s1 = new silnik();
            a1.setSilnik(s1);
        }
    }
}
