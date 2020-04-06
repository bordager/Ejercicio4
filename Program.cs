using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca una palabra");
            string palabra1;
            palabra1 = Console.ReadLine();
            Console.WriteLine("Introduzca otra palabra");
            string palabra2;
            palabra2 = Console.ReadLine();
            bool check = false;

            for (int i = 0; i < palabra1.Length -1; i++)
            {
                check = false;
                string letra1 = palabra1.Substring(i, 1);

                for (int u = 0; u < palabra2.Length - 1; u++)
                {
                    string letra2 = palabra2.Substring(palabra2.Length - i - 1, 1);

                    if (letra1 == letra2)
                    {
                        check = true;
                        break;
                    }

                }

                if (check == false)
                { 
                    break;
                }
            }

            if (check == true)  
            {
                Console.WriteLine("Es un anagrama");
            }
            else
            {
                Console.WriteLine("No es un anagrama");
            }


            Console.Read();
        }
    }
}