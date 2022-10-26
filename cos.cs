using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zad 1
            int n = int.Parse(Console.ReadLine());
            // for (int i = 0; i <= n; i++){
            //   Console.Write("*-|");}
            //
            // int n = 5;
            // for (int i = 0; i <= n; i++){
            //   for (int j =1; j<=i;j++){
            //     Console.Write("*");
            //   }
            //   Console.WriteLine();
            // }

            // int n = 5;
            // for (int i = 0; i <= n; i++)
            // {
            //   for (int j = n; j>i;j--)
            //   {
            //     Console.Write("*");
            //   }
            //   Console.WriteLine();
            // }

            /*            int n = 5;
                        for (int i = 0; i <= n; i++)
                        {
                            for (int l = 0; l <= i; l++)
                            {
                                Console.Write(" ");
                            }
                            for (int j = n; j > i; j--)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }*/
            // for (int i=0; i<=n; i++)
            // {
            //   for (int l=0; l<=i; l++)
            //   {
            //     Console.Write(" ");
            //   }
            //   for (int j=n; j>i; j--)
            //   {
            //     Console.Write("*");
            //   }
            //   Console.WriteLine();
            // }
            /*            for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < i; k++) { Console.Write('*'); }
                            Console.WriteLine();
                        }*/
            /*            for(int i = 0; i <= n+1; i++)
                        {
                            for (int j = 0; j < n+1; j++) 
                            {
                                if (i >= j) Console.Write("");
                                else Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i <= n + 1; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                if (n-j >= i) Console.Write(" ");
                                else Console.Write("*");
                            }
                            Console.WriteLine();
                        }*/
            //zad 7
            /*            for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n+1; j++)
                            {
                                if (i==1 || j == 1 || i == n ||j == n||(i==n/2+1&&j==n/2+1)) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/

            //zad6
            /*            for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (i == n-j+1) Console.Write("?");
                                if(i==j) Console.Write("*");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/
            //zad5
            /*            for (int i = 1; i < n + 1; i++)
                        {
                            for (int j = 1; j < n + 1; j++)
                            {
                                if (j==n/2+1) Console.Write("*");
                                else if (i == n/2+1) Console.Write("-");
                                else Console.Write(" ");
                            }
                            Console.WriteLine();
                        }*/
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (j + i == n-1 ||) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
