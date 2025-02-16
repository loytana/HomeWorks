namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the pipe: ");
            double length = Math.Round(Convert.ToDouble(Console.ReadLine()) / 0.5) * 0.5;
            Console.WriteLine(length);
        }
    }
}
