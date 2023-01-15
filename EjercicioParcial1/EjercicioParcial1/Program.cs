using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poncini_Patricio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string texto = string.Empty;
            char[] delimitadores = { ' ', ',', '.', ';' };
            string[] vector;
            do
            {
                Console.WriteLine("Ingrese una opción:");
                Console.WriteLine("1. Ingresar párrafo");
                Console.WriteLine("2. Mostrar información del párrafo");
                Console.WriteLine("0. Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    // INGRESAR PÁRRAFO
                    case 1:
                        Console.Clear();
                        texto = validarString("Ingrese un párrafo con un mínimo de 5 caracteres y un máximo de 35 caracteres");
                        break;

                    // MOSTRAR INFO DEL PÁRRAFO INGRESADO
                    case 2:
                        // Cantidad de palabras que tiene el párrafo
                        Console.Clear();
                        vector = texto.Split(delimitadores);
                        Console.WriteLine("\a");
                        Console.WriteLine($"Cantidad de palabras: {vector.Length} palabras");
                        Console.WriteLine("Palabras ingresadas: ");
                        for (int i = 0; i < vector.Length; i++)
                        {
                            Console.WriteLine("- " + vector[i]);
                        }

                        Console.WriteLine("\a");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("\a");

                        // Mostrar palabras terminadas en "a"
                        Console.WriteLine("Palabras terminadas en a: ");
                        foreach (string terminadaA in vector)
                        {
                            if (terminadaA.ToLower().EndsWith("a"))
                            {
                                Console.WriteLine("- " + terminadaA);
                            }
                        }

                        Console.WriteLine("\a");
                        Console.WriteLine("-------------------------------------------------");
                        Console.WriteLine("\a");

                        // Ordenamiento por caracteres
                        Array.Sort(vector);
                        Console.WriteLine("Ordenamiento por caracteres:");
                        Console.WriteLine(String.Join("\n- ", vector));
                        Console.ReadKey();
                        break;
                    // SALIR
                    case 0:
                        break;
                }
                Console.Clear();
            } while (opcion != 0);
        }

        static string validarString(string msj)
        {
            string parrafo;
            do
            {
                Console.WriteLine(msj);
                parrafo = Console.ReadLine();
                if (parrafo == string.Empty || parrafo.Length < 5 || parrafo.Length > 35)
                {
                    Console.Clear();
                    Console.WriteLine("El párrafo ingresado no cumple con las condiciones indicadas. Intente nuevamente a continuación");
                }
            } while (parrafo == string.Empty || parrafo.Length < 5 || parrafo.Length > 35);
            return parrafo;
        }
    }
}


