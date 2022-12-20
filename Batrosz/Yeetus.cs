using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class liber
    {
        private int weight;
        private string color;
    }
    class heart
    {
        private int weight;
        private string condition;
    }
    class body
    {
        private liber liver;
        private heart heart;

        public body(liber aliver, heart aheart)
        {
            this.liver = aliver;
            this.heart = aheart;
        }
        public void eat()
        {
            Console.WriteLine("Mniam mniam");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            liber l1 = new liber();
            heart h2 = new heart();
            body b1 = new body(l1, h2);
        }
    }
}
