using System.Text;
namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            string input = Console.ReadLine();
            string[] words = input.Split();
            int length = 0;
            StringBuilder found = new StringBuilder(); //использую StringBuilder, чтобы уменьшить расход памяти
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > length)
                {
                    found.Clear();
                    length = words[i].Length; 
                    found.Append(words[i]);
                }
            }
            Console.WriteLine(found);
        }
    }
}
