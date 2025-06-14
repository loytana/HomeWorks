namespace Task16
{
    internal class Program
    {        
        static int[] GenerateNumbersArray(int size)
        {
            Thread.Sleep(3000); 

            Random rnd = new Random();
            return Enumerable.Range(1, size)
                   .Select(_ => rnd.Next(1, 100))
                   .ToArray();
        }
                
        static double CalculateAverage(int[] numbers)
        {
            Thread.Sleep(2000); 

            return numbers.Average();
        }

        static async Task<int[]> GenerateNumbersArrayAsync(int size)
        {
            await Task.Delay(3000); 
            return GenerateNumbersArray(size); 
        }

        static async Task<double> CalculateAverageAsync(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            await Task.Delay(2000); 
            return CalculateAverage(numbers); 
        }

        static void Main(string[] args)
        {
            Task.Run(() => GenerateNumbersArray(10))
                .ContinueWith(task =>
                {
                    int[] numbers = task.Result;
                    Console.WriteLine($"Сгенерирован массив: {string.Join(", ", numbers)}");

                    return CalculateAverage(numbers);
                })
                .ContinueWith(task =>
                {
                    Console.WriteLine($"Среднее значение: {task.Result:F2}");
                })
                .Wait();

            CallWithAsyncAwait().Wait();
        }

        static async Task CallWithAsyncAwait()
        {
            int[] numbers = await GenerateNumbersArrayAsync(10);
            Console.WriteLine($" Асхинхронно сгенерирован массив: {string.Join(", ", numbers)}");

            double average = await CalculateAverageAsync(numbers);
            Console.WriteLine($"Асинхронное среднее значение: {average:F2}");
        }
    }
}
