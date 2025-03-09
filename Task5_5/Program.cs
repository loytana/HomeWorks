namespace Task5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] task = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(-50, 51);
                Console.Write("{0} ", task[i]); //проверка
            }
            for (int i = 0; i < task.Length; i++)
            {
                if (i < task.Length / 2)
                {
                    for (int j = 0; j < task.Length / 2; j++)
                    {
                        if (task[i] < task[j])
                        {
                            int temp = task[i];
                            task[i] = task[j];
                            task[j] = temp;
                        }
                    }
                }
                else
                {
                    for (int j = task.Length / 2; j < task.Length; j++)
                    {
                        if (task[i] > task[j])
                        {
                            int temp = task[i];
                            task[i] = task[j];
                            task[j] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            foreach (int a in task)
            {
                Console.Write("{0} ", a); //проверка
            }
        }
    }
}
