namespace Program
{
    class Zadanie
    {
        static void Celsjusz(double f)
        {
            Console.WriteLine("Temperatura wynosi: " + (f - 32) / (1.8));
        }
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Podaj temperarture w stopniach Fahrenheita");
            x = double.Parse(Console.ReadLine());
            Celsjusz(x);
            Console.ReadKey();
        }
    }

}