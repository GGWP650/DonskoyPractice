using System;

// Класс для передачи данных о температуре при вызове события
public class TemperatureChangedEventArgs : EventArgs
{
    public double Temperature { get; }

    public TemperatureChangedEventArgs(double temperature)
    {
        Temperature = temperature;
    }
}

// Класс TemperatureSensor, который генерирует событие TemperatureChanged
public class TemperatureSensor
{
    // Событие TemperatureChanged
    public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;

    private double temperature;

    // Метод для установки новой температуры
    public void SetTemperature(double newTemperature)
    {
        if (newTemperature != temperature)
        {
            temperature = newTemperature;
            // Генерация события при изменении температуры
            OnTemperatureChanged(new TemperatureChangedEventArgs(temperature));
        }
    }

    // Метод для вызова события TemperatureChanged
    protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs e)
    {
        TemperatureChanged?.Invoke(this, e);
    }
}

// Класс Thermostat, который подписывается на событие TemperatureChanged
public class Thermostat
{
    private double targetTemperature;

    public Thermostat(double targetTemperature)
    {
        this.targetTemperature = targetTemperature;
    }

    // Метод-обработчик события изменения температуры
    public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
    {
        if (e.Temperature < targetTemperature)
        {
            Console.WriteLine($"Температура {e.Temperature}°C. Включаем отопление.");
        }
        else
        {
            Console.WriteLine($"Температура {e.Temperature}°C. Выключаем отопление.");
        }
    }
}

class Zadanie5
{
    static void Run(string[] args)
    {
        // Создание экземпляра сенсора и термостата
        TemperatureSensor sensor = new TemperatureSensor();
        Thermostat thermostat = new Thermostat(22.0); // Целевая температура 22°C

        // Подписка термостата на событие TemperatureChanged
        sensor.TemperatureChanged += thermostat.OnTemperatureChanged;

        // Имитация изменения температуры
        sensor.SetTemperature(20.0); // Должно включить отопление
        sensor.SetTemperature(24.0); // Должно выключить отопление
    }
}