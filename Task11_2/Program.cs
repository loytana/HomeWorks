using System.ComponentModel.DataAnnotations;

namespace Task11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите макс. высоту для птиц");
            int maxAltitudeBird = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите макс. высоту для самолётов");
            int maxAltitudeAirplane = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество пассажиров");
            int countPassengers = int.Parse(Console.ReadLine());
            IFlyable[] iFlyables = new IFlyable[] {
                new Bird(maxAltitudeBird),
                new Airplane(maxAltitudeAirplane, countPassengers)
            };
            foreach (var iFlyable in iFlyables)
            {
                iFlyable.Fly();
            }
        }
    }
    public interface IFlyable
    {
        void Fly();
        int MaxAltitude { get; }
    }
    public class Bird : IFlyable
    {
        public int MaxAltitude { get; }
        public Bird(int maxAltitude) 
        {
            MaxAltitude = maxAltitude;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров");
        }
    }
    public class Airplane : IFlyable
    {
        public int MaxAltitude { get; }
        int CountPassengers { get; }
        public Airplane(int maxAltitude, int countPassengers)
        {
            MaxAltitude = maxAltitude;
            CountPassengers = countPassengers;
        }
        public void Fly()
        {
            Console.WriteLine($"Лечу на высоте {MaxAltitude} метров. Везу {CountPassengers} пассажиров");
        }
    }
}
