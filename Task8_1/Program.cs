namespace Task8_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введи два числа");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                try
                {
                    Console.WriteLine("Введи код операции");
                    int k = Convert.ToInt32(Console.ReadLine());
                    ValidateCode(k);
                    switch (k)
                    {
                        case 1:
                            Console.WriteLine(a + b);
                            break;
                        case 2:
                            Console.WriteLine(a - b);
                            break;
                        case 3:
                            Console.WriteLine(a * b);
                            break;
                        case 4:
                            Console.WriteLine(a / b);
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Код операции не является числом - {ex.Message}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Введено не число - {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Делить на ноль нельзя - {ex.Message}");
            }

        }        
        static void ValidateCode(int k)
        {
            if (k < 1 || k > 4)
                throw new ArgumentException($"код операции = {k} выходит за допустимый диапазон [1-4]");
        }
    }
}
