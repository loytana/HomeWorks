namespace Task5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int[,] task = new int[n, n];
            Random rnd = new Random();
            int count = 0;
            int countDiag1 = 0;
            int countDiag2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    task[i, j] = rnd.Next(0, 2);
                    Console.Write("{0} ", task[i, j]);
                }
                Console.WriteLine(); //проверка
            }
            bool flag = false;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j && task[i, j] == 1)
                    {
                        countDiag1++;
                    }
                }

                if (countDiag1 == n)
                {
                    flag = true;
                    break;
                }

                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1 && task[i, j] == 1)
                    {
                        countDiag2++;
                    }
                }

                if (countDiag2 == n)
                {
                    flag = true;
                    break;
                }


                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (task[i, j] == 1)
                    {
                        count++;
                    }
                }

                if (count == n)
                {
                    flag = true;
                    break;
                }

                count = 0;
                for (int j = 0; j < n; j++)
                {
                    if (task[j, i] == 1)
                    {
                        count++;
                    }
                }

                if (count == n)
                {
                    flag = true;
                    break;
                }

            }
            if (flag)
            {
                Console.WriteLine("Выиграли");
            }
            else
            {
                Console.WriteLine("Не выиграли");
            }
        }
    }
}
