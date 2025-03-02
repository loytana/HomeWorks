namespace Task4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= a;

            }
            Console.WriteLine(res);
        }
    }
}
