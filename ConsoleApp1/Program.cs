namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine(">");
            }
            else if (b > a)
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
