namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объектов обоих типов
            Building building = new Building("Фридрихштрассе, 27", 137.56, 45);
            MultiBuilding multiBuilding = new MultiBuilding("Линкштрассе, 10", 153.1, 150, 19, true);

            //Проверка. Вызов переопределенных методов
            Console.WriteLine();
            building.DisplayInfo();
            Console.WriteLine(building.CalculateTax());            
            multiBuilding.DisplayInfo();
            Console.WriteLine(multiBuilding.CalculateTax());

            //Upcasting (приведение производного класса к базовому)
            Building buildingUpcast = multiBuilding;
            Console.WriteLine();
            buildingUpcast.DisplayInfo();

            // Downcasting (обратное приведение с проверкой типа)
            if (buildingUpcast is MultiBuilding)
            {
                MultiBuilding buildingDowncast = (MultiBuilding)buildingUpcast;
                Console.WriteLine();
                Console.WriteLine(buildingDowncast.CalculateTax());
                buildingDowncast.DisplayInfo();
            }

            //Использование уникальных методов производного класса
            Console.WriteLine();
            Console.WriteLine($"Налог с учетом всех коэффициентов: {multiBuilding.CalculateTax()}");
            Console.WriteLine($"Средняя площадь этажа: {multiBuilding.AreaPerFloor:F2}");
        }
    }
    public class Building
    {
        protected string _address;
        protected double _area;
        protected int _yearBuilt;
        public Building(string address, double area, int yearBuilt)
        {
            _address = address;
            _area = area;
            _yearBuilt = yearBuilt;
            BuildingAge = DateTime.Now.Year - _yearBuilt;
        }
        public virtual double CalculateTax()
        {
            return _area * 1000;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Адрес здания: {_address}\nПлощадь здания: {_area}\nГод постройки: {_yearBuilt}\nВозраст: {BuildingAge}\nНалог: {CalculateTax()}");
        }
        protected readonly int BuildingAge;
    }
    sealed public class MultiBuilding : Building
    {
        private int _floors;
        private bool _hasElevator;
        public MultiBuilding(string address, double area, int yearBuilt, int floors, bool hasElevator)
            : base(address, area, yearBuilt)
        {
            _floors = floors;
            _hasElevator = hasElevator;
            AreaPerFloor = _area / _floors;
        }        
        public override double CalculateTax()
        {            
            return _hasElevator ? (1 + (_floors - 1) * 0.05) * _area * 1000 + 5000 : (1 + (_floors - 1) * 0.05) * _area * 1000;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Количество этажей: {_floors}\nНаличие лифта: {(_hasElevator ? "есть" : "нет")}\nПлощадь на этаж: {AreaPerFloor:F2}");
        }
        public readonly double AreaPerFloor;

    }
}
