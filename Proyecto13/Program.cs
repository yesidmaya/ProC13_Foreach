using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto13
{
    class Program
    {

        static void Main(string[] args)
        {
            int numero = -1;
            ArrayList almacenNumeroPrimo = new ArrayList();
            String mostrarPantalla = String.Empty;

            Console.WriteLine("CALCULAR NUMEROS PRIMOS ENTRE 0 Y ...");
            Console.WriteLine("Digite el numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los numero primos que hay hasta el numero: " + numero.ToString() + " son: ");
            for (int i = 2; i <= numero; i++)
            {
                if (esNumeroPrimo(i))
                {
                    almacenNumeroPrimo.Add(i);
                }
                    
            }   
            
            foreach (int numeroPrimo in almacenNumeroPrimo)
            {
                mostrarPantalla += " " + numeroPrimo.ToString();
            }

            Console.WriteLine(mostrarPantalla);
            Console.ReadLine();

        }

        public static Boolean esNumeroPrimo(int numero) // funcion o metodo
        {
            Boolean esPrimo = true;
            int contador = 2;

            while (esPrimo && contador != numero )
            {
                if (numero % contador == 0)
                {
                    esPrimo = false;
                }
                contador++;
            }

            return esPrimo;
        }
    }
}
