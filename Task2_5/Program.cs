namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the pipe: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Ceiling(length));
        }
    }
}
