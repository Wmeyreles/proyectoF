using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_final
{
    class Program
    {
        static void Main(string[] args)
        {
            int c1, c2, c3, c4, c5, tc, p;
            Console.Write("primera calificacion");
            c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("segunda calificacion");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("tercera calificacion");
            c3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("cuarta calificacion");
            c4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("quinta calificacion");
            c5 = Convert.ToInt32(Console.ReadLine());
            tc = c1 + c2 + c3 + c4 + c5;
            p = tc / 5;
            Console.WriteLine("el total de las calificaciones es {0}", tc);
            Console.WriteLine("el promedio de las calificaciones es {0}", p);
            Console.ReadKey();
        }
    }
}
