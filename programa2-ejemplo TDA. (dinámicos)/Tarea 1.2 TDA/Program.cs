using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //libreria necesaria

namespace programa2_ejemplo_TDA_dinámicos
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            Stack pila = new Stack();
            // ingreso de elementos a la pila:
            pila.Push(" Primero ");
            pila.Push(" Segundo ");
            pila.Push(" Tercero ");
            foreach (string var in pila)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("\n");
            // Peek retorna el valor que esta al tope de la pila
            Console.Write(" El Tope de la Pila es: ");
            Console.WriteLine(pila.Peek());
            //retorna el valor del tope eliminandolo:
            valor = pila.Pop().ToString();
            Console.WriteLine(" Eliminado Pila... " + valor);
            Console.WriteLine("\n");
            // mostrar contenido de la pila:
            foreach(string var in pila)
            {
                Console.WriteLine(var);
            }
            Console.ReadKey();
        }
    }
}
