namespace Task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи длину ребра куба");
            double a = Double.Parse(Console.ReadLine());
            double volume, surface;
            CalcCube(a, out volume, out surface);
            Console.WriteLine($"Объём куба: {volume}");
            Console.WriteLine($"Площадь поверхности куба: {surface}");
        }
        static void CalcCube(double a, out double volume, out double surface)
        {
            volume = Math.Pow(a, 3);
            surface = 6 * Math.Pow(a, 2);
        }
    }
}
