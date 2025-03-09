namespace Task5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 10;
            const int n = 5;
            int[,] task = new int[m, n];
            int count = 2;
            int x = 0;
            int y = 0;
            int dx = 0;
            int dy = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    task[i, j] = 0;
                    Console.Write("{0} ", task[i, j]);
                }
                Console.WriteLine(); //проверка
            }
            task[0, 0] = 1;
            while (count <= n * m)
            {
                if (x + dx >= 0 && x + dx <= m - 1 && y + dy >= 0 && y + dy <= n - 1 && task[x + dx, y + dy] == 0)
                {
                    task[x + dx, y + dy] = count;
                    count++;
                    x += dx;
                    y += dy;
                }
                else if (dy == 1)
                {
                    dy = 0;
                    dx = 1;
                }
                else if (dx == 1)
                {
                    dy = -1;
                    dx = 0;
                }
                else if (dy == -1)
                {
                    dy = 0;
                    dx = -1;
                }
                else if (dx == -1)
                {
                    dy = 1;
                    dx = 0;
                }
                Console.WriteLine("Error");
            }
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 3} ", task[i, j]);
                }
                Console.WriteLine(); //проверка
            }
        }
    }
}
