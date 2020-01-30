using System;

namespace MayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int numero;

            for(int i = 0; i < 10; i++)
            {
                int a = i + 1;
                Console.WriteLine("Escriba el " + a + " numero");
                numero = int.Parse(Console.ReadLine());
                arr[i] = numero;
            }

            int maxi = arr[0];
            int mini = arr[0];

            for(int i = 0; i < 10; i++)
            {
                if(maxi < arr[i])
                {
                    maxi = arr[i];
                }

                else if(mini > arr[i])
                {
                    mini = arr[i];
                }
            }

            Console.WriteLine("El numero mayor es " + maxi);
            Console.WriteLine("El numero menor es " + mini);
            Console.ReadLine();
        }
    }
}
