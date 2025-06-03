namespace Task14_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> warehouse = new Dictionary<string, int>();

            warehouse.Add("A001", 10);
            warehouse.Add("B205", 25);
            warehouse.Add("C307", 15);

            bool hasB205 = warehouse.ContainsKey("B205");
            Console.WriteLine($"Есть ли товар с артикулом B205? {hasB205}");

            warehouse["A001"] = 8;

            if (warehouse.TryGetValue("C307", out int count))
            {
                Console.WriteLine($"Количество наушников: {count}");
            }

            warehouse["B205"] = 30;

            warehouse.Remove("C307");

            Console.WriteLine("Текущий инвентарь:");
            foreach (KeyValuePair<string, int> ware in warehouse)
            {
                Console.WriteLine($"Артикул: {ware.Key},  Количество: {ware.Value}");
            }

            bool empty = warehouse.Count == 0 ? true : false;
            Console.WriteLine($"Инвентарь пуст? {empty}");

            warehouse.Clear();
            Console.WriteLine($"Количество товаров после очистки: {warehouse.Count}");
        }
    }
}
