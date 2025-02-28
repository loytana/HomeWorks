namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            if (a * b >= p * q + r * s)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }
        }
    }
}
