namespace Task5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] task = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(0, 11);
                Console.Write("{0} ", task[i]); //проверка
            }
            Console.WriteLine();
            for (int i = 0; i < task.Length / 2; i++)
            {
                int temp = task[i];
                task[i] = task[task.Length - 1 - i];
                task[task.Length - 1 - i] = temp;
            }
            foreach (int a in task) //проверка
            {
                Console.Write("{0} ", a);
            }
        }
    }
}
