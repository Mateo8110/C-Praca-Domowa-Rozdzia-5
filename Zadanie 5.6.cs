namespace Zadanie
{
    class Program
    {
        static int[] Mnozenie(int mnoznik1, int[] tab)
        {
            int[] tab1 = { 1, 4, 6, 8, 2 };

            for (int i = 0; i < tab1.Length; i++)
            {
                tab1[i] = tab1[i] * mnoznik1;
                Console.Write(tab1[i] + "  ");
            }
            return tab1;
        }
        static string[] Mnozenie2(int mnoznik2, string[] tab)
        {
            string[] tab2 = 
        }
        static void Main(string[] args)
        {
            int mnoznik1;
            int[] tab2 = new int[5];
            Console.WriteLine("Podaj mnożnik: ");
            mnoznik1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] tab = Mnozenie(mnoznik1, tab2);

            Console.ReadKey();
        }
    }
}