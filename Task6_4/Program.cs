using System.Text;

namespace Task6_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conditionString = ""; //решил сделать цикл, чтобы было удобнее проверять, заодно повторил циклы:)
            do
            {
                Console.WriteLine("Введите имя: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите город: ");
                string city = Console.ReadLine();
                StringBuilder info = new StringBuilder().Append("Имя: ");
                info.Append(name);
                info.Append(", Возраст: ");
                info.Append(age);
                info.Append(", Город: ");
                info.Append(city);
                Console.WriteLine(info.ToString());
                Console.WriteLine("Если нужно ввести ещё данные, то нажмите \" + \"");
                conditionString = Console.ReadLine();
            }
            while (String.Compare(conditionString, "+") == 0);
            
        }
    }
}
