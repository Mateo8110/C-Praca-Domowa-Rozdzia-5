namespace Zadanie
{
    class Program
    {
        static int Przedzial(int a, int b, int x)
        {
            if (a < x && x < b) return 1;
            else return 0;
        }
        static void Main(string[] args)
        {
            int a, b, x;

            Console.WriteLine("Podaj a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj x: ");
            x = int.Parse(Console.ReadLine());

            

            if (Przedzial(a, b, x) == 1)
                Console.WriteLine("x należy do przedziału obustronnie otwartego");
            else
                Console.WriteLine("X nie należey do przedziału obustronnie otwartego");


            Console.ReadKey();



        }
    }
}