using System;

class Program
{
    static void Main(string[] args)
    {
        while (true) // Bucle infinito hasta que el usuario escriba "salir"
        {
            Console.WriteLine("Dame un valor (o escribe 'salir' para terminar):");
            string? input = Console.ReadLine(); // Permitimos que input sea anulable

            // Verificamos si input es null antes de proceder
            if (input == null)
            {
                Console.WriteLine("No se ingresó ningún valor. Inténtalo de nuevo.");
                continue; // Pasamos a la siguiente iteración del bucle
            }

            // Si el usuario escribe "salir", rompemos el bucle
            if (input.ToLower() == "salir")
            {
                Console.WriteLine("Adiós!");
                break;
            }

            // Intentamos convertir el input a un número
            if (int.TryParse(input, out int numero))
            {
                // Verificamos si el número es par o impar
                if (numero % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"El número {numero} es: par");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"El número {numero} es: impar");
                }
                Console.ResetColor(); // Reseteamos el color para mantener la consola limpia
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.ResetColor();
            }
        }
    }
}
