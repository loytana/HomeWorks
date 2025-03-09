namespace Task5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] task = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(0, 11);
                Console.Write("{0} ", task[i]); //проверка
            }
            for (int i = 0; i < task.Length; i++)
            {
                for (int j = 0; j < task.Length; j++)
                {
                    if (task[i] < task[j])
                    {
                        int temp = task[i];
                        task[i] = task[j];
                        task[j] = temp;
                    }
                }
            }
            Console.WriteLine("\n{0}, {1}", task[task.Length - 2], task[task.Length - 1]);

        }
    }
}
