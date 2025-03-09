namespace Task5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;
            int[,] task = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 == j % 2)
                    {
                        task[i,j] = 1;
                    }
                    Console.Write("{0} ", task[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
