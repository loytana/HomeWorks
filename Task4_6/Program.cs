namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            if (a == 1)
            {
                Console.WriteLine("Является");
            }
            else if (a == 0)
            {
                Console.WriteLine("Не является");
            }
            else
            {
                do
                {
                    if (a % 2 != 0)
                    {
                        count++;
                    }
                    a /= 2;
                } while (a >= 2);
                if (count == 0)
                {
                    Console.WriteLine("Является");
                }
                else
                {
                    Console.WriteLine("Не является");
                }
            }
        }
    }
}
