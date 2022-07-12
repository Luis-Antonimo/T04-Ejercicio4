using System;

namespace T04Ejercicio4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Diga un número (A):");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Diga otro número (B):");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("El número A es mayor que B.");
            }
            else
            {
                if (a == b)
                {
                    Console.WriteLine("El número A es igual a B.");
                }
                else
                {
                    Console.WriteLine("El número B es mayor que A.");
                }
            }
        }
    }
}
