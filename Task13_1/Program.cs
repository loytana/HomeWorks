namespace Task13_1
{
    internal class Program
    {
        public delegate int Transformer(int x);

        static int[] Transform(int[] array, Transformer transformer)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = transformer(array[i]);
            }
            return result;
        }

        static void Main(string[] args)
        {
            var numbers = new int[] { -2, 3, -5, 7, 10 };

            //Удвоение всех чисел
            Transformer doubleTransformer = x => x * 2;
            var doubled = Transform(numbers, doubleTransformer);
            foreach (int x in doubled)
            
                Console.Write($"{x} ");
            
            Console.WriteLine();

            //Возведение в квадрат
            Transformer squareTransformer = x => x * x;
            var squared = Transform(numbers, squareTransformer);
            Console.WriteLine("Квадраты чисел: " + string.Join(", ", squared));

            //Замена чисел на их модули
            Transformer absTransformer = Math.Abs;
            var absolutes = Transform(numbers, absTransformer);
            Console.WriteLine("Модули чисел: " + string.Join(", ", absolutes));
        }
    }
}