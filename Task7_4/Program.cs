namespace Task7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = FindMax(10, 25, 5, 30, 15);
            Console.WriteLine($"Max number: {maxNumber}");
        }
        static int FindMax(params int[] nums)
        {
            int max = 0;
            foreach (int num in nums)
                if (num > max)
                    max = num;
            return max;
        }
    }
}
