namespace Task3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int med = a < b && b < c || a > b && b > c ? b : a < c && c < b || a > c && c > b ? c : a;
            Console.WriteLine(med);
        }
    }
}
