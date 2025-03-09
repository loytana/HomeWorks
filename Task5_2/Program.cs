namespace Task5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] task = new int[10];
            int countPos = 0;
            int countNeg = 0;
            int countNull = 0;
            for (int i = 0; i < task.Length; i++)
            {
                task[i] = rnd.Next(-20, 21);
                if (task[i] > 0)
                {
                    countPos++;
                }
                else if (task[i] < 0)
                {
                    countNeg++;
                }
                else
                {
                    countNull++;
                }
                Console.Write("{0} ", task[i]); //проверка
            }
            Console.WriteLine("\nКоличество пол. чисел = {0}\nКоличество отр. чисел = {1}\nКоличество равных нулю = {2}", countPos, countNeg, countNull);            
        }
    }
}
