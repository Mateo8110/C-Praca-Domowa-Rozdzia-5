namespace Zadanie
{
    class Program
    {
        
        static void Rysuj(int szerokosc, int dlugosc, string znak)
        {
            for (int i = 0; i < dlugosc; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {
            int dlugosc, szerokosc;
            string znak;

            Console.WriteLine("Podaj rozmiary prostokąta i znak ");
            Console.WriteLine();
            Console.WriteLine("Podaj dlugosc: ");
            dlugosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj szerokosc: ");
            szerokosc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            znak = Console.ReadLine();


            Rysuj(dlugosc, szerokosc, znak);
            
            
            

            Console.ReadKey();
        }
    }
}
