using System;

namespace Taller3
{
    public class Rombo
    {
        // Property of the size of the rhombus
        public int Tamano { get; set; }
        public Rombo(int n)
        {
            Tamano = n;
            // with evens it looked weird so I make it odd again so it looks symmetrical
            if (Tamano % 2 == 0)
            {
                Tamano = Tamano + 1;
            }
        }
        // Method responsible for drawing the rhombus
        public void ImprimirRombo()
        {
            int medio = Tamano / 2;
            Console.WriteLine("\n--- Aquí está tu rombo hueco ---");
            // Top part of the rhombus
            for (int i = 0; i <= medio; i++)
            {
                for (int j = 0; j < medio - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    if (k == 0 || k == 2 * i)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            // Bottom part of the rhombus (I inverted it)
            for (int i = medio - 1; i >= 0; i--)
            {
                for (int j = 0; j < medio - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < (2 * i + 1); k++)
                {
                    if (k == 0 || k == 2 * i)
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== EXERCISE 32: HOLLOW RHOMBUS ===");
            Console.Write("Enter the size of the diamond: ");
            string entrada = Console.ReadLine();
            int numero = Convert.ToInt32(entrada);
            // Creo el objeto de la clase Rombo
            Rombo miRombo = new Rombo(numero);
            miRombo.ImprimirRombo();
            Console.WriteLine("Ready! any key to finish...");
            Console.ReadKey();
        }
    }
}