using System;
using System.Diagnostics;

namespace AlgoritmosOrdenamiento_2023_II
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el tamaño del arreglo: ");
            int N = int.Parse(Console.ReadLine());
            int [] A=Genera(N);
            Imprime(A);
            Console.WriteLine("Arreglo Ordenado");

            Ordenamiento.Burbuja(A);
            Imprime(A);

            Console.ReadLine();

        }

        public static int[]  Genera(int N)
        {
            int[] A= new int[N];
            Random aleatorio= new Random();
            for(int i=0; i<N; i++)
            {
                A[i] =(int)(1000*aleatorio.NextDouble());

            }

            return A;
        }

        public static void Imprime(int[] A)
        {
            Console.WriteLine("Imprime el Arreglo: ");
            foreach( int a in A )
            {
                Console.Write(" {0} ",a);
            }
            Console.WriteLine("Fin del Arreglo");

        }

    }
}
