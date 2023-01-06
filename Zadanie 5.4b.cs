namespace Zadanie
{
    class Program
    {
        static void Mnozenie(int mnoznik, int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = mnoznik * tab[i];
                Console.Write(tab[i] + "  ");
            }    
        }
        
        
        
        static void Main(string[] args)
        {

            int mnoznik1;
            int[] tab1 = { 1, 4, 6, 8, 2 };
            Console.WriteLine("Tablica przed mnozeniem: ");
            for (int i = 0; i < tab1.Length; i++)
            {
                Console.Write(tab1[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Podaj mnoznik: ");
            mnoznik1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tablica po mnozeniu: ");
            Mnozenie(mnoznik1, tab1);

            
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}