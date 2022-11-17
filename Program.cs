/*3) Desarrollar un programa que solicite al usuario ingresar 6 números y almacenar en ARRAY y
por último se lo debe recorrer para calcular y mostrar el promedio de los valores.*/

using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int []arreglo = new int[6];
            int suma=0;
            float promedio=0f;


            Console.WriteLine("Bienvenido...");
            Console.WriteLine("INGRESE 6 NUMEROS ENTEROS:");

            for(int i=0; i<6; i++){
                arreglo[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("USTED INGRESO:");
            for(int i=0; i<6; i++){
                suma=suma + arreglo[i];
                Console.Write(""+ arreglo[i] +" | ");
            }

            promedio=(float)suma / 6;

        Console.WriteLine(" ");
        Console.WriteLine("el promedio es: " + (float)promedio);

        }
    }
}
