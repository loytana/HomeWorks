namespace Task14_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> players = new List<string>();

            players.Add("Иванов");
            players.Add("Петров");
            players.Add("Сидоров");

            players.Insert(1, "Козлов");

            bool hasPetrov = players.Contains("Петров");
            Console.WriteLine($"Есть ли игрок 'Петров' в команде? {hasPetrov}");

            players.Remove("Сидоров");

            int indexGoat = players.IndexOf("Козлов");
            Console.WriteLine($"Индекс игрока 'Козлов': {indexGoat}");

            players.Sort();

            Console.WriteLine("Текущий состав команды:");
            foreach (var player in players)
            {
                Console.WriteLine($"{players.IndexOf(player.ToString()) + 1}. {player.ToString()}");
            }

            bool empty = players.Count == 0 ? true : false;
            Console.WriteLine($"Команда пуста? {empty}");

            players.Clear();
            Console.WriteLine($"Количество игроков после очистки: {players.Count}");
        }
    }
}
