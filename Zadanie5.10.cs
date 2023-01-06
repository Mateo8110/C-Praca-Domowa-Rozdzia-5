using System.Diagnostics.CodeAnalysis;

namespace Zadanie
{
    class Program
    {
        static int Oblicz(int n)
        {
            if (n <= 1)
                return 1;
            else
                return (n + Oblicz(n - 1));
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Podaj n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(Oblicz(n));
            Console.ReadKey();
        }
    }
}