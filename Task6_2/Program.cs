namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            input = input.ToLower().Replace(" ", "");
            string inputReversed = new string(input.Reverse().ToArray());
            if (String.Compare(input, inputReversed) == 0)
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }
    }
}
