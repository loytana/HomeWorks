namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц: ");
            string month = Console.ReadLine();
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите общую сумму продаж: ");
            double sum = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество проданных товаров: ");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine("Отчёт о продажах за {0} {1}", month, year);
            Console.WriteLine("Информация о продажах:");
            string sumResult = String.Format("Общая сумма продаж: {0:0,0.00} р.", sum);
            Console.WriteLine(sumResult);
            string countResult = String.Format("Количество проданных товаров: {0:0,0} шт.", count);
            Console.WriteLine(countResult);
            double cost = sum / count;
            string costResult = String.Format("Средняя стоимость товара: {0:0,0.00} р.", cost);
            Console.WriteLine(costResult);
        }
    }
}
