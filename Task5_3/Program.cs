using System.Diagnostics.Metrics;

namespace Task5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] task = new int[10];
            int min = 50;
            int max = 0;
            int minInd = 0;
            int maxInd = 0;
            Random rnd = new Random();
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(0, 51);
                if (task[i] <= min)
                {
                    min = task[i];
                    minInd = i;
                }
                if (task[i] >= max)
                {
                    max = task[i];
                    maxInd = i;
                }
                Console.Write("{0} ", task[i]); //проверка
            }
            Console.WriteLine("\nЗначение макс. = {0}\nИндекс макс. = {1}\nЗначение мин. = {2}\nИндекс мин. = {3}\n", max, maxInd, min, minInd);
        }
    }
}
