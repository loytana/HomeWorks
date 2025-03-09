namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] task = new int[10];
            int count = 0;
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(0, 101);
                count = (task[i] % 2 == 0) ? ++count : --count;
                Console.Write("{0} ", task[i]); //для проверки
            }
            if (count > 0)
            {
                Console.WriteLine("\nБольше чётных");
            }
            else if (count < 0)
            {
                Console.WriteLine("\nБольше нечётных");
            }
            else
            {
                Console.WriteLine("\nКоличество чётных и нечётных элементов массива одинаково");
            }
        }
    }
}
