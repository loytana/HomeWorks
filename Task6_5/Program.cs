using System.Text.RegularExpressions;

namespace Task6_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер");
            string number = Console.ReadLine();
            Regex regex = new Regex(@"\+[0-9]\([0-9]{3,}\)[0-9]{3,}-[0-9]{2,}-[0-9]{2,}");
            if (regex.IsMatch(number))
                Console.WriteLine("Является");
            else 
                Console.WriteLine("Не является");
        }
    }
}
