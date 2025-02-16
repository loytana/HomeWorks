internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the degrees: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the minutes: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the seconds: ");
        int s = Convert.ToInt32(Console.ReadLine());
        double r = Math.Round((d + m / 60 + s / 3600) * Math.PI / 180, 4);
        Console.WriteLine(r);
    }
}