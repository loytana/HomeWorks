namespace Task4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            double res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= a;

            }
            Console.WriteLine(1/res);
        }
    }
}
