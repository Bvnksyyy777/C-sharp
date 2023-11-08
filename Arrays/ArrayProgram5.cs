using System;

namespace Arrays
{
    class MainClass
    {
        static int [] fun(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] % 2 == 0 && i%2!=0)
                {
                    tab[i] = 99;
                }
            }
            int n = tab.Length;
            int[] res= new int[n];
            return (res);
        }
        static void Main(string[] args)
        {
            s:
            try
            {
                Console.Write("Enter number of array elements: ");
            }
            catch(Exception)
            {
                Console.Write("Only numbers are allowed!");
                goto s;
            }
            int n = int.Parse(Console.ReadLine());
            int[] tab = new int [n];
            for(int i = 0; i < tab.Length; i++)
            {
                i:
                Console.Write("Enter a num: ");
                try
                {
                    tab[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("Only numbers are allowed!");
                    goto i;
                }
            }
            Console.WriteLine("New array: ");
            tab=fun(tab);
            Console.WriteLine(tab);
        }
    }
}

