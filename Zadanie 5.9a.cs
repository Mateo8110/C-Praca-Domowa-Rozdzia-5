namespace Program
{
    class Zadanie
    {
        static int ciagFib(int n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return ciagFib(n - 1) + ciagFib(n - 2);
        }


        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Podaj n-ty wyraz ciągu Fibonnaciego: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(n + "-ty wyraz ciągu fibonnaicego to: " + ciagFib(n));
            Console.ReadKey();
        }
    }
}