using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    class Program
    {
        static void Main(string[] args)

        {
            // 1. Creación e inicialización del arreglo
            int[] arreglo = new int[10]; // Crear un arreglo de 10 elementos
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = i + 1; // Inicializar con los números del 1 al 10
            }

            // Imprimir el arreglo completo
            Console.WriteLine("Arreglo inicial:");
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Para nueva línea

            // 2. Modificación del tercer elemento
            arreglo[2] = 99; // Cambiar el valor del tercer elemento (índice 2)

            // Imprimir el arreglo después de la modificación
            Console.WriteLine("Arreglo modificado:");
            foreach (int num in arreglo)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Para nueva línea

            // 3. Suma de los elementos del arreglo
            int suma = 0;
            foreach (int num in arreglo)
            {
                suma += num; // Sumar cada elemento
            }

            // Imprimir la suma
            Console.WriteLine("La suma de tu arreglo es " + suma);

            // 4. Búsqueda de un número en el arreglo
            Console.Write("Ingresa un numero para buscar en el arreglo ");
            string input = Console.ReadLine();
            int numbus = Convert.ToInt32(input);

            // Buscar el número en el arreglo

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numbus)
                {
                    Console.WriteLine($"El número {numbus} fue encontrado en la posición {i}.");


                }else{
                    
                        Console.WriteLine("Elemento no encontrado.");
                }
                Console.WriteLine("El programa a finalizado");
                Console.ReadKey();
            }
        }
    }
}
    


    

