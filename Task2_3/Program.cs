namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of segment: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double millis = Math.Round(a * 25.4 % 10, 1); //умножил сразу на 25.4, чтобы привести к мм, вместо 2.54 и дальнейшего умножения на 10
            int meters = (int) (a * 0.0254); //умножил сразу на 0.0254, чтобы привести к метрам, вместо 2.54 и дальнейшего деления на 100
            int santis = (int) (a * 2.54 - meters * 100);
            
            Console.Write("{0} м {1} см {2} мм", meters, santis, millis);
        }
    }
}
