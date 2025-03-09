namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] task = new int[10];
            int countEven = 0;
            int countOdd = 0;
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(0, 101);
                if (task[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                Console.Write("{0} ", task[i]);
            }
            if (countEven > countOdd)
            {
                Console.WriteLine("\nБольше чётных");
            }
            else if (countOdd < countEven)
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
