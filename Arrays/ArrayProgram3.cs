using System;

namespace Arrays
{
    class MainClass
    {
        static int SumOfOdd(int[] tab1)
        {
            int suma = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] % 2 != 0)
                {
                    suma += tab1[i];
                }

            }
            return suma;

        }
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 2, 84, 90, 821, 9012, 54, 90, 12, 78, 14 };
            Console.WriteLine(SumOfOdd(tab1));
        }
    }
}