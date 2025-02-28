namespace Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (b > a && b > c)
            {
                Console.WriteLine(b);
            }
            else if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
