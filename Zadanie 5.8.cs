namespace Zadanie
{
    class Program
    {

        static int SumaCyfr(int x, int wynik)
        {
            while(x != 0)
            {
                wynik = wynik + (x % 10);
                x = x / 10;
            }
            return wynik;
        }
        
        
        
        static void Main(string[] args)
        {
            int x = 0;
            int wynik1 = 0;  
            Console.WriteLine("Podaj x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Suma cyfr podanej liczby wynosi: {0}", SumaCyfr(x, wynik1));
            
            Console.ReadKey();

        }
    }
}