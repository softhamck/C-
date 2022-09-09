/*Crear un vector de 20 elementos con  valores  numéricos diferentes. Hallar el mayor valor y su posición y el valor promedio*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VectorNum = {16, 99, 27, 84, 30, 77, 39, 61, 48, 53 , 91, 100, 10, 23, 35, 77, 89, 98, 51, 73};
            ValorMayor(VectorNum);
            ValorPromedio(VectorNum);
        }
        static void ValorMayor(int[] vect)
        {
            int numMayor=0, posicion=0;
            for (int i = 0; i < 20; i++)
            {   
                if(vect[i] > numMayor)
                {
                    numMayor = vect[i];
                    posicion=i;
                }
            }
            Console.WriteLine($"El mayor valor es: {numMayor} y su posicion es: {posicion}");
        }
        static void ValorPromedio(int[] vector)
        {
            int promedio =0;
            for (int i = 0; i < 20; i++)
            {
                promedio+=vector[i];
            }
            Console.WriteLine($"El valor promedio es: {promedio/20}");
        }
    }
}
