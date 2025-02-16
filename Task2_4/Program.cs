namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32 (Console.ReadLine());
            int dig_1 = a / 1000;
            int dig_2 = a / 100 % 10;
            int dig_3 = a / 10 % 10;
            int dig_4 = a % 10;
            a = dig_1 * 1000 + dig_4 * 100 + dig_3 * 10 + dig_2;
            Console.WriteLine(a);
        }
    }
}
