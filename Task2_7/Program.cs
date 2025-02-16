namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} \n{1}", b, a); //ну не сказано, что мы должны именно значения обменять:))
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("{0} \n{1}", a, b);
        }
    }
}
