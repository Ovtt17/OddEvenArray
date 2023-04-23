/*
Escriba un programa en el que se genere aleatoriamente un array de 20 números enteros entre
1 y 99. El array ha de quedar de tal forma que los números impares deben quedar al inicio del array y
los números pares al final. Mostrar el array original y el array con la distribución indicada.
*/
using System;

namespace OddEvenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize an array of 20 integers
            int[] numbers = new int[20];

            // Randomly generate 20 integers between 1 and 99 and store them in the array
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            // Display the original array
            Console.WriteLine("Original array:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Rearrange the array so that odd numbers are at the beginning and even numbers at the end
            int[] rearrangedNumbers = new int[20];
            int oddIndex = 0;
            int evenIndex = numbers.Length - 1;
            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    rearrangedNumbers[oddIndex] = number;
                    oddIndex++;
                }
                else
                {
                    rearrangedNumbers[evenIndex] = number;
                    evenIndex--;
                }
            }

            // Display the modified array
            Console.WriteLine("Rearranged array:");
            foreach (int number in rearrangedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
