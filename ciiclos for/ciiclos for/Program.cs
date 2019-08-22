using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciiclos_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,z;
            Console.WriteLine("Imprime los numeros para comenzar");
            Console.WriteLine("de donde quieres empezar el ciclo (X)?");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De donde iniciamos el ciclo (Y)");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto quieres que avanze");
            z = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                for( int i=x; i>y; i-=z)
                {
                    Console.WriteLine("i =+ i");
                }
            }
            else
            {
                for (int i=x; i<y; i+=z)
                {
                    Console.WriteLine("i =+ i");
                }
            }
        }
    }
}
