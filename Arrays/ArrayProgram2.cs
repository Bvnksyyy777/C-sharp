using System;

namespace Arrays
{
    class MainClass
    {
        static bool IsInArray(int[] tab1, int a)
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                if (tab1[i] == a)
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 2, 84, 90,821,9012,54,90,12,78,14 };
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(IsInArray(tab1, a));
        }
    }
}