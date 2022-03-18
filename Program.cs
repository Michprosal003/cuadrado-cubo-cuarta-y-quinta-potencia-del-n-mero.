using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, resultado;


            Console.Title = "Elevar un número al cuadrado";

            Console.WriteLine("Ingresar un numero");
            numero = int.Parse(Console.ReadLine());

            resultado = numero * numero;


            Console.WriteLine(" El numero " + numero + " elevado al cuadrado es :" + resultado);
            Console.ReadKey();

        }
    }
}
