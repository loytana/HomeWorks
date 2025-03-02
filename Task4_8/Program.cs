namespace Task4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.Write(a % 10);
                a /= 10;
            } while (a > 9);
            Console.WriteLine(a);
        }
    }
}
