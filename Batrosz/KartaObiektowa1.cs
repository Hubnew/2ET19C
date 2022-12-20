using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Rower
    {
        private Producent producent;
        private string kolor;
        private Maretrial material;
        public void jedz()
        {
            Console.WriteLine("Wroooom");
        }
        public void setColor(string akolor)
        {
            this.kolor = akolor;
        }
        public void setMaterial(Maretrial amaterial)
        {
            this.material = amaterial;
        }
        public string getColor()
        {
            return kolor;
        }
        public Rower(Producent nazwa)
        {
            producent = nazwa;
            
        }
    }
        public class Producent
        {
            private string nazwa;
            private string nip;
            public string getNazwa(string nazwa)
            {
            return "Nazwa";
            }
            public string getNip(string anip)
            {
                return anip;
            }
            public void setNazwa(string anazwa)
            {
                this.nazwa = anazwa;
            }
        }
        public class Maretrial
        {
            private string typ;
            private int id;
            private double cena;
            public void setTyp(string atyp)
            {
                this.typ = atyp;
            }
            public string getTyp()
            {
                return this.typ;
            }
            public double getCena()
            {
                return cena;
            }
            public void setID( int aid)
            {
                this.id = aid;
            }
        }

        internal class Program
        {
        static void Main(string[] args)
        {
            Maretrial material = new Maretrial();
            Producent prod = new Producent();
            Rower rower = new Rower(prod);
            rower.setMaterial(material);

        }
    }
}
