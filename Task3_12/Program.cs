namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int s = a / 100;
            int d = a % 100 / 10;
            int e = a % 10;
            String res = "";
            switch (s)
            {
                case 1:
                    res += "сто";
                    break;
                case 2:
                    res += "двести";
                    break;
                case 3:
                    res += "триста";
                    break;
                case 4:
                    res += "четыреста";
                    break;
                case 5:
                    res += "пятьсот";
                    break;
                case 6:
                    res += "шестьсот";
                    break;
                case 7:
                    res += "семьсот";
                    break;
                case 8:
                    res += "восемьсот";
                    break;
                case 9:
                    res += "девятсот";
                    break;
                default:
                    
                    break;
            }
            if (d == 1)
            {
                switch (e)
                {
                    case 1:
                        res += " одиннадцать";
                        break;
                    case 2:
                        res += " венадцать";
                        break;
                    case 3:
                        res += " тринадцать";
                        break;
                    case 4:
                        res += " четырнадцать";
                        break;
                    case 5:
                        res += " пятнадцать";
                        break;
                    case 6:
                        res += " шестнадцать";
                        break;
                    case 7:
                        res += " семнадцать";
                        break;
                    case 8:
                        res += " восемнадцать";
                        break;
                    case 9:
                        res += " девятнадцать";
                        break;
                    default:

                        break;
                }
            }
            else
            {
                switch (d)
                {
                    case 2:
                        res += " двадцать";
                        break;
                    case 3:
                        res += " тридцать";
                        break;
                    case 4:
                        res += " сорок";
                        break;
                    case 5:
                        res += " пятьдесят";
                        break;
                    case 6:
                        res += " шестьдесят";
                        break;
                    case 7:
                        res += " семьдесят";
                        break;
                    case 8:
                        res += " восемьдесят";
                        break;
                    case 9:
                        res += " девяносто";
                        break;
                    default:

                        break;
                }
                switch (e)
                {
                    case 1:
                        res += " один";
                        break;
                    case 2:
                        res += " два";
                        break;
                    case 3:
                        res += " три";
                        break;
                    case 4:
                        res += " четыре";
                        break;
                    case 5:
                        res += " пять";
                        break;
                    case 6:
                        res += " шесть";
                        break;
                    case 7:
                        res += " семь";
                        break;
                    case 8:
                        res += " восемь";
                        break;
                    case 9:
                        res += " девять";
                        break;
                    default:

                        break;
                }
            }
            Console.WriteLine(res);
            
        }
    }
}
