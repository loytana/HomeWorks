namespace Task4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            if (a == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                while (a > 0)
                {
                    count++;
                    a /= 10;
                }
                Console.WriteLine(count);
            }
        }
    }
}
