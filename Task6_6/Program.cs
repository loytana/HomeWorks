using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task6_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "";
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!#;%:?*]).{14,}$");
            do
            {
                Console.WriteLine("Создайте пароль");
                password = Console.ReadLine();                
            }
            while (!regex.IsMatch(password));
        }
    }
}
