using System;

namespace Arrays
{
    class MainClass
    {
        static double Avg(int[] tab1, int a, int b)
        {
            return (tab1[a] + tab1[b]) / 2;
        }
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 2, 84, 90,23,112,456,12,75,1002,632,987 };
        ai:
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            if (a > tab1.Length - 1)
            {
                Console.WriteLine("Out of index!");
                goto ai;
            }
        bi:
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            if (b > tab1.Length - 1)
            {
                Console.WriteLine("Out of index!");
                goto bi;
            }
            Console.WriteLine(Avg(tab1, a, b));
        }
    }
}