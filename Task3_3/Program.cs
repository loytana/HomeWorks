namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            if (b > a && b > c && b > d)
            {
                Console.WriteLine(b);
            }
            else if (a > b && a > c && a > d)
            {
                Console.WriteLine(a);
            }
            else if (c > b && c > a && c > d)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(d);
            }
        }
    }
}
