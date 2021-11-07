using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Recorridos_por_árboles_Post_orden
{
    class Program
    {
        static void Main(string[] args)
        {
            AMM Miarbolito = new AMM();
            Miarbolito.insertar('A');
            Miarbolito.insertar('B');
            Miarbolito.insertar('C');
            Miarbolito.insertar('D');
            Miarbolito.insertar('E');
            Miarbolito.insertar('F');
            Miarbolito.insertar('G');
            Miarbolito.insertar('H');
            Miarbolito.insertar('I');
            Miarbolito.insertar('J');
            Miarbolito.insertar('K');
            Miarbolito.insertar('L');

            Miarbolito.preordenrecursivo();
            Miarbolito.inordenrecursivo();
            Miarbolito.postOrdenrecursivo();


            Console.WriteLine("Hola el programa concluyo preciona cualquier tecla para salir,");
            Console.ReadKey();
        }
    }
}
