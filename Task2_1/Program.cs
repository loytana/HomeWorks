internal class Program
{
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        int d = a;
        a = c;
        c = b;
        b = d;
        Console.WriteLine("{0} \n{1} \n{2}", a, b, c);
    }
}