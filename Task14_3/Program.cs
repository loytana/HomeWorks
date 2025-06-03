using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task14_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> emails = new HashSet<string>();

            emails.Add("alice@example.com");
            emails.Add("bob@example.com");
            emails.Add("charlie@example.com");

            if (emails.Add("alice@example.com") == false)
            {
                Console.WriteLine($"Дубликат alice@example.com добавлен? {emails.Add("alice@example.com")}");
            }

            Console.WriteLine($"Есть ли bob@example.com в подписчиках? {emails.Contains("alice@example.com")}");
            Console.WriteLine($"Есть ли dave@example.com в подписчиках? {emails.Contains("dave@example.com")}");

            HashSet<string> newSubscribers = new HashSet<string>() { "bob@example.com", "dave@example.com", "eve@example.com"};

            HashSet<string> unionSubscribers = new HashSet<string>(emails);
            unionSubscribers.UnionWith(newSubscribers);

            Console.WriteLine("Подписчики после объединения:");
            foreach (string subscriber in unionSubscribers)
            {
                Console.WriteLine(subscriber);
            }

            HashSet<string> commonSubscribers = new HashSet<string>(emails);
            commonSubscribers.IntersectWith(newSubscribers);
            Console.WriteLine("Общие подписчики:");
            foreach (string commonsubscriber in commonSubscribers)
            {
                Console.WriteLine(commonsubscriber);
            }

            Console.WriteLine($"Удалили charlie@example.com? {unionSubscribers.Remove("charlie@example.com")}");

            Console.WriteLine($"Всего подписчиков: {unionSubscribers.Count}");

            HashSet<string> testGroup = new HashSet<string>() { "alice@example.com", "dave@example.com"};
            Console.WriteLine($"testGroup является подмножеством? {testGroup.IsSubsetOf(unionSubscribers)}");

            unionSubscribers.Clear();
            Console.WriteLine($"Подписчиков после очистки: {unionSubscribers.Count}");
        }
    }
}
