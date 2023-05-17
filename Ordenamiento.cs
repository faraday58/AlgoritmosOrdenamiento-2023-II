using System;

namespace AlgoritmosOrdenamiento_2023_II
{
    internal class Ordenamiento
    {
        public static void  Burbuja(int [] A  )
        {
            int N=A.Length;

            for (int i=0; i < N; i++ )
            {
                for ( int j=0; j < N-1; j++)
                {                   

                    if (A[j] > A[j+1]  )
                    {
                        int Aux= A[j];
                        A[j] = A[j + 1];
                        A[j+1] = Aux;

                    }
                }        
                        
            }


        }


    }
}
