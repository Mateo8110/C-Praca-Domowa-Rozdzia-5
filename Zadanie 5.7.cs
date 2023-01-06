namespace Zadanie
{
    class Program
    {
        static void Ciag(int x,int n, int suma)
        {
            Console.WriteLine(suma = (2 * x + 1 + n) * n / 2);
        }
           
        static void Main(string[] args)
        {
            int x, n;
            int suma = 0;
            Console.WriteLine("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("N-ty wyraz ciągu wynosi: ");
            Ciag(x,n,suma);

            Console.ReadKey();
        }
    }
}