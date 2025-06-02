namespace Task13_2
{
    // Уточню на всякий случай, что тут использовал ИИ, т.к. полностью самостоятельно не смог докрутить
    // Делегат для события изменения состояния
    public delegate void DeviceStateChangedHandler(object sender, DeviceStateEventArgs e);

    // Класс для передачи данных о событии
    public class DeviceStateEventArgs : EventArgs
    {
        public string DeviceType { get; }
        public string State { get; }
        public DateTime ChangeTime { get; }

        public DeviceStateEventArgs(string deviceType, string state)
        {
            DeviceType = deviceType;
            State = state;
            ChangeTime = DateTime.Now;
        }
    }

    // Класс умного дома
    public class SmartHomeSystem
    {
        

        // Событие изменения состояния устройства
        public event DeviceStateChangedHandler DeviceStateChanged;

        // Состояния устройств
        private bool isLightOn = false;
        private int currentTemperature = 20;
        private bool isDoorLocked = true;

        // Методы управления устройствами
        public void TurnOnLight()
        {
            isLightOn = true;
            OnDeviceStateChanged("Light", "Включен");
        }

        public void TurnOffLight()
        {
            isLightOn = false;
            OnDeviceStateChanged("Light", "Выключен");
        }

        public void SetTemperature(int temperature)
        {
            currentTemperature = temperature;
            OnDeviceStateChanged("Thermostat", $"Температура установлена на {temperature}°C");
        }

        public void LockDoor()
        {
            isDoorLocked = true;
            OnDeviceStateChanged("Door", "Заблокирована");
        }

        public void UnlockDoor()
        {
            isDoorLocked = false;
            OnDeviceStateChanged("Door", "Разблокирована");
        }

        // Метод для вызова события
        protected virtual void OnDeviceStateChanged(string deviceType, string state)
        {
            DeviceStateChanged?.Invoke(this, new DeviceStateEventArgs(deviceType, state));
        }
    }

    class Program
    {
        static void Main()
        {
            var smartHome = new SmartHomeSystem();

            // Подписываемся на событие изменения состояния
            smartHome.DeviceStateChanged += (sender, e) =>
            {
                Console.WriteLine($"[{e.ChangeTime:HH:mm:ss}] {e.DeviceType}: {e.State}");
            };

            // Демонстрация работы системы
            Console.WriteLine("=== Управление умным домом ===");

            smartHome.TurnOnLight();
            System.Threading.Thread.Sleep(1000);

            smartHome.SetTemperature(23);
            System.Threading.Thread.Sleep(1000);

            smartHome.UnlockDoor();
            System.Threading.Thread.Sleep(1000);

            smartHome.LockDoor();
            System.Threading.Thread.Sleep(1000);

            smartHome.TurnOffLight();
        }
    }
}
