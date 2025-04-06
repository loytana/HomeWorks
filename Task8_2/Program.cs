namespace Task8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                ValidateAge(age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        static void ValidateAge(int age)
        {
            if (age < 0)
                throw new ArgumentException("Возраст не может быть отрицательным");
            else if (age > 150)
                throw new ArgumentException("Слишком большой возраст");
            else
            {
                Console.WriteLine("Корректный возраст");
            }
        }
    }
}
