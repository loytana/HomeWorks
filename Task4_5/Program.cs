namespace Task4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            do
            {
                Console.WriteLine("Введите число из диапазона [20; 60]");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a > 60 || a < 20);
        }
    }
}
