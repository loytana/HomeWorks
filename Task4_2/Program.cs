namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double strangeSum = 1;
            for (double i = 2; i <= n; i++)
            {
                strangeSum += 1 / i;
            }
            Console.WriteLine(strangeSum);
        }
    }
}
