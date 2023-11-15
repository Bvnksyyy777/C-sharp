using System;
namespace RekurencyjneZadania
{
    class MainClass
    {
        static bool CzyJest(int[] t, int x, int n)
        {
            while (n <= t.Length - 1)
            {
                if (t[n]==x && t[n + 1] == x)
                {
                    return true;
                }
                n++;
                CzyJest(t, x, n);
            }
            return false;
        }
        static int SumaWZakresie(int[] t, int a, int b)
        {
            int suma = 0;
            for(int i=a;i<b; i++)
            {
                suma+= t[i];
            }
            return suma;
        }
        static int IloczynSumPodzielnychPrzez3i7(int[] t, int n = 0)
        {
            int s3 = 0;
            int s7 = 0;
            while(n<t.Length)
            {
                if (t[n] % 3 == 0)
                {
                    s3 += t[n];
                }
                if (t[n] % 7 == 0)
                {
                    s7 += t[n];
                }
                n++;
                IloczynSumPodzielnychPrzez3i7(t, n );
            }
            return s3 * s7;
        }
        static double PoliczSrednia2(int[] t, int i = 0, int acc=0)
        {
            for (i = 0; i < t.Length; i++)
            {
                acc += t[i];
            }
            return Convert.ToDouble(acc / t.Length);
        }
        static double PoliczSrednia(int[] t, int i = 0)
        {
            int s = 0;
            for(i=0;i < t.Length;i++)
            {
                s += t[i];
            }
            t[0] = s;
            return Convert.ToDouble(s/t.Length);
        }
        static int ZnajdzMax(int[] t1, int n)
        {
            int max=-1; ;
            while(n < t1.Length)
            {
                if (t1[n] > max)
                {
                    max = t1[n];
                }
                n++;
                ZnajdzMax(t1, n);
            }
            return max;
        }
        static int IleSpelnia(int[] t1, int n=0)
        {
            int ile = 0;
            while(n<t1.Length)
            {
                if (t1[n]%2!=0 && t1[n] % 3 != 0)
                {
                    ile++;
                }
                n++;
                IleSpelnia(t1, n);
            }
            return ile;
        }
        static int SumaParzystych(int[] t1, int n = 0)
        {
            if (n >= t1.Length)
            {
                return 0;
            }
            if (n % 2 == 0)
            {
                return t1[n] + SumaParzystych(t1, n + 1);
            }
            return SumaParzystych(t1, n + 1);
        }
        static void Main(string[] args)
        {
            int n = 0;
            int[] t1 = { 1, 3, 7, 7, 12, 90, 56, 23, 93, 11, 5, 123, 15, 15 };
            Console.WriteLine("Zadanie 1");
            Console.WriteLine("Suma liczb o parzystych indeksach "+SumaParzystych(t1));
            Console.WriteLine("Zadanie 2");
            Console.WriteLine("Liczb spelniajacych dany warunek jest "+IleSpelnia(t1));
            Console.WriteLine("Zadanie 3");
            Console.WriteLine("Max to "+ZnajdzMax(t1,n));
            Console.WriteLine("Zadanie 4");
            Console.WriteLine("Srednia liczb w tablicy to "+PoliczSrednia(t1));
            Console.WriteLine("Zadanie 5");
            Console.WriteLine("Srednia liczb w tablicy to " + PoliczSrednia2(t1));
            Console.WriteLine("Zadanie 6");
            Console.WriteLine("Iloczyn sum podzielnych przez 3 i 7 wynosi " + IloczynSumPodzielnychPrzez3i7(t1));
            Console.WriteLine("Zadanie 7");
            int a, b;
            a:
            Console.Write("Podaj a: ");
            try
            {
                 a = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tylko liczby!");
                goto a;
            }
            b:
            Console.Write("Podaj b: ");
            try
            {
                 b = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tylko liczby!");
                goto b;
            }
            Console.WriteLine("Suma w zakresie od " + a + " do " + b + " wynosi " + SumaWZakresie(t1,a,b));
            Console.WriteLine("Zadanie 8");
            x:
            Console.Write("Podaj ktorej liczby szukasz: ");
            int x;
            int k = 0;
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Tylko liczby!");
                goto x;
            }
            if (CzyJest(t1, x,k) == true)
            {
                Console.WriteLine("Jest");
            }
            else
            {
                Console.WriteLine("Nie ma");
            }
        }
    }
}