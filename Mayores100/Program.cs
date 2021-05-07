using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayores100
{
    class Program
    {
        private int[] vec;
        public void Cargar()
        {
            Console.Write("Cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());
            vec = new int[n];
            for (int f=0; f<vec.Length; f++)
            {
                Console.Write("Ingrese el valor del componente:  " );
                String linea;
                linea = Console.ReadLine();
                vec[f] = int.Parse(linea);
            }
        }

        public void imprimir()
        {
            int cant = 0;
            foreach (var valor in vec)
                if (valor >100)
                {
                    cant++;
                }
            Console.Write("La cantidad de elementos mayores a 100 son: " + cant);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program m = new Program();

            m.Cargar();
            m.imprimir();
        }
    }
}
