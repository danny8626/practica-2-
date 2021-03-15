using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
             int num =2, total=0, suma=0;
            while (num != 0)
            {
                Console.Write("Escribe un numero: ");
                num = int.Parse(Console.ReadLine());
                suma += num;
                total += 1; 
            }
            Console.WriteLine();
            Console.WriteLine("El total de numeros ingresados es: " + total);
            Console.WriteLine("La suma de los numeros ingresados es: " + suma);
            Console.WriteLine("Ya sali del Programa =( , Enter para continuar...");
            Console.ReadKey();
        }
    }
}
