using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Task15
{
    internal class Program
    {
        class Computer
        {
            public int Code { get; set; }
            public string Brand { get; set; }
            public string CPUType { get; set; }
            public double CPUFrequency { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int GPUVRAM { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public override string ToString() 
            {
                return $"{Code}: {Brand} | CPU: {CPUType} {CPUFrequency}GHz | RAM: {RAM}GB | HDD: {HDD}GB | GPU: {GPUVRAM}GB | Price: {Price:C} | Qty: {Quantity}";
            }

        }
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>
            {
                new Computer {Code = 1, Brand = "HP Pavilion", CPUType = "Intel Core i5", CPUFrequency = 2.5, RAM = 8, HDD = 1000, GPUVRAM = 4,  Price = 750, Quantity = 5},
                new Computer {Code = 2, Brand = "Dell Inspiron", CPUType = "Intel Core i5", CPUFrequency = 2.5, RAM = 12, HDD = 1000, GPUVRAM = 4,  Price = 850, Quantity = 9},
                new Computer {Code = 3, Brand = "Dell Inspiron", CPUType = "Intel Core i7", CPUFrequency = 3.2, RAM = 16, HDD = 512, GPUVRAM = 6, Price = 1200, Quantity = 3},
                new Computer {Code = 4, Brand = "Lenovo IdeaPad", CPUType = "AMD Ryzen 5", CPUFrequency = 3.0, RAM = 12, HDD = 2000, GPUVRAM = 4, Price = 850, Quantity = 7},
                new Computer {Code = 5, Brand = "Apple iMac", CPUType = "Apple M1", CPUFrequency = 3.2, RAM = 16, HDD = 512, GPUVRAM = 8, Price = 1500, Quantity = 2},
                new Computer {Code = 6, Brand = "Asus ROG", CPUType = "Intel Core i9", CPUFrequency = 3.7, RAM = 32, HDD = 2000, GPUVRAM = 12, Price = 2500, Quantity = 1},
                new Computer {Code = 7, Brand = "Acer Nitro", CPUType = "AMD Ryzen 7", CPUFrequency = 3.5, RAM = 16, HDD = 1000, GPUVRAM = 6, Price = 1100, Quantity = 4},
                new Computer {Code = 8, Brand = "Asus ROG", CPUType = "Intel Core i5", CPUFrequency = 2.5, RAM = 16, HDD = 1000, GPUVRAM = 4,  Price = 950, Quantity = 7},
            };


            //определение компьютеров с указанным процессором
            string cpu = Console.ReadLine();
            var typeComputers = computers
                .Where(computer => computer.CPUType.Equals(cpu))
                .ToList();
            foreach ( var computer in typeComputers )
            {
                Console.WriteLine($"{computer.Code} {computer.Brand} {computer.CPUType} {computer.CPUFrequency} {computer.RAM} {computer.HDD} {computer.GPUVRAM} {computer.Price} {computer.Quantity}");
            }
            Console.WriteLine();

            //определение компьютеров с определенной ОЗУ
            int minRAM = int.Parse(Console.ReadLine());
            var byRAM = computers
                .Where(computer => computer.RAM >= minRAM)
                .ToList();
            foreach (var computer in byRAM)
            {
                Console.WriteLine($"{computer.Code} {computer.Brand} {computer.CPUType} {computer.CPUFrequency} {computer.RAM} {computer.HDD} {computer.GPUVRAM} {computer.Price} {computer.Quantity}");
            }
            Console.WriteLine();

            //сортировка по стоимости
            var sortedByPrice = computers
                .OrderBy(computer => computer.Price)
                .ToList();
            foreach (var computer in sortedByPrice)
            {
                Console.WriteLine($"{computer.Code} {computer.Brand} {computer.CPUType} {computer.CPUFrequency} {computer.RAM} {computer.HDD} {computer.GPUVRAM} {computer.Price} {computer.Quantity}");
            }
            Console.WriteLine();

            //группировка по типу процессора
            var groupedByCPU = computers
                .GroupBy(computer => computer.CPUType)
                .ToList();
            foreach (var group in groupedByCPU)
            {
                foreach(var computer in group)
                {
                    Console.WriteLine($"{computer.Code} {computer.Brand} {computer.CPUType} {computer.CPUFrequency} {computer.RAM} {computer.HDD} {computer.GPUVRAM} {computer.Price} {computer.Quantity}");
                }
                Console.WriteLine();
            }

            //самый дорогой и самый бюджетный компьютер
            Computer minPriceComputer = computers.OrderBy(c => c.Price).FirstOrDefault(); 
            Computer maxPriceComputer = computers.OrderByDescending(c => c.Price).FirstOrDefault();           
            Console.WriteLine($"Самый бюджетный компьютер: {minPriceComputer}");
            Console.WriteLine($"Самый дорогой компьютер: {maxPriceComputer}");
            Console.WriteLine();

            //есть ли хотя бы один компьютер в количестве не менее 30 штук?
            bool hasThirty = computers.Any(computer => computer.Quantity >= 30);
            Console.WriteLine(hasThirty);
        }
    }
}
