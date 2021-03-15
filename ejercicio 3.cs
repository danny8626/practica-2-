using System;

namespace ejercico_3
{
    class Program
    {
        static void Main(string[] args)
        {
             //Ejercicio 3//
            // Console.WriteLine("Programa que genera la tabla de multiplicar de los numeros del 1 al 100");

            for (int i=1; i <= 500; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Tabla del {i}");
                    Console.WriteLine();
                    for (int num=1; num<=10; num++)
                    {
                       
                        Console.WriteLine($"{num} x {i} = " + num * i);
                    }
                   
                }
            }
            Console.ReadKey();
        }
    }
}

            


