namespace Task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи стороны первого треугольника");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("А теперь второго");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            if (Square(a,b,c) > Square(d,e,f))
                Console.WriteLine("У первого треугольника площадь больше");
            else if (Square(a, b, c) == Square(d, e, f))
                Console.WriteLine("Площади равны");
            else
                Console.WriteLine("У второго треугольника площадь больше");
        }
        static double Square(int a, int b, int c)
        {
            double p = (a + b + c)/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
