namespace Task4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Является");
            }
            else
            {
                do
                {
                    a %= 2;
                } while (a >= 2);
                if (a == 0)
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
