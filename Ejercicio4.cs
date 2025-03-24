using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructurasDatos
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> Divisas = new Dictionary<string, char>();
            Divisas.Add("Euro", '€');
            Divisas.Add("Dollar", '$');
            Divisas.Add("Yen", '¥');
            Console.WriteLine("Escribe el nombre de una divisa para obtener su símbolo. Disponibles: Euro, Dollar, Yen");
            string answer = Console.ReadLine();
            if (Divisas.TryGetValue(answer, out char divisa))
            {
                Console.WriteLine("El símbolo de la divisa " + answer + " es " + divisa);
            }
            // Creo que el euro sale con ? porque la consola no conoce ese carácter.
            else
            {
                Console.WriteLine("El símbolo de esa divisa no se encuentra en este diccionario.");
            }
        }

    }

}
