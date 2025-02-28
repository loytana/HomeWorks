namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10 && n < 15)
            {
                switch (n)
                {
                    case 10:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 11:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 12:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 13:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 14:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    default:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                }
            }
            else
            {
                switch (n % 10)
                {
                    case 1:
                        Console.WriteLine("Мы построили {0} дом", n);
                        break;
                    case 2:
                        Console.WriteLine("Мы построили {0} дома", n);
                        break;
                    case 3:
                        Console.WriteLine("Мы построили {0} дома", n);
                        break;
                    case 4:
                        Console.WriteLine("Мы построили {0} дома", n);
                        break;
                    case 5:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 6:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 7:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 8:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 9:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    case 10:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                    default:
                        Console.WriteLine("Мы построили {0} домов", n);
                        break;
                }
            }
        }
    }
}
