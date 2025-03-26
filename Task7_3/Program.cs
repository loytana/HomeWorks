namespace Task7_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через пробел (например: 1 2 3 4):");
            string input = Console.ReadLine();
            string[] stringItems = input.Split(new[] { ' ' });
            int[] numbers;
            numbers = Array.ConvertAll(stringItems, int.Parse);
            PrintNumbers(numbers);
            Console.WriteLine();
            PrintNumbers(numbers, true);
        }
        static void PrintNumbers(int[] numbers, bool reverse = false)
        {
            if (reverse)
                for (int i = numbers.Length - 1; i >= 0; i--)
                    Console.Write($"{numbers[i]} ");
            else 
                foreach (int number in numbers)
                    Console.Write($"{number} ");
        }
    }
}
