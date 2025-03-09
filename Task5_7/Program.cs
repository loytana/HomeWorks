namespace Task5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int m = 5;
            int[,] task = new int[n, m];
            int max = 0;
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    task[i, j] = rnd.Next(0, 11);
                    Console.Write("{0} ", task[i, j]);
                }
                Console.WriteLine(); //проверка
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (task[i, j] > max)
                    {
                        max = task[i, j];
                    }
                }
                Console.WriteLine("Макс. значение в {0} строке = {1}", i, max);
                max = 0;
            }
        }
    }
}
