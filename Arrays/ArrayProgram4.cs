using System;

namespace Arrays
{
    class MainClass
    {
        static long SumOfEvenNumbersAndEvenIndex(int[] tab1, int n)
        {
            int suma = 0;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] % 2 == 0 && i % 2 == 0 && i > n)
                {
                    suma += tab1[i];
                    tab1[i] = 99;
                }

            }
            return suma;

        }
        static void Main(string[] args)
        {
            Console.Write("Enter index number: ");
            int n = int.Parse(Console.ReadLine());
            int[] tab1 = { 1, 22, 3, 15, 60, 35, 4, 6, 10,10023,652,87,129,350,672,900,649 };
            Console.WriteLine(SumOfEvenNumbersAndEvenIndex(tab1, n));
        }
    }
}
