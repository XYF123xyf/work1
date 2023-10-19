namespace work4
{
    using System;

    // 气象站类
    public class WeatherStation
    {
        public DateTime LastUpdateTime { get; private set; }
        public float Temperature { get; private set; }
        public float Humidity { get; private set; }

        public event EventHandler<WeatherDataChangedEventArgs> WeatherDataChanged;

        public void UpdateWeatherData(float temperature, float humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
            LastUpdateTime = DateTime.Now;

            OnWeatherDataChanged(new WeatherDataChangedEventArgs(temperature, humidity));
        }

        protected virtual void OnWeatherDataChanged(WeatherDataChangedEventArgs e)
        {
            WeatherDataChanged?.Invoke(this, e);
        }
    }

    // 屏幕显示类
    public class ScreenDisplay
    {
        public void ShowWeatherData(object sender, WeatherDataChangedEventArgs e)
        {
            Console.WriteLine("Temperature: " + e.Temperature);
            Console.WriteLine("Humidity: " + e.Humidity);
        }
    }

    // 数据库保存类
    public class DatabaseSaver
    {
        public void SaveWeatherData(object sender, WeatherDataChangedEventArgs e)
        {
            // 保存气象数据到数据库的代码
            Console.WriteLine("Saving weather data to database...");
        }
    }

    // 气象数据改变事件参数类
    public class WeatherDataChangedEventArgs : EventArgs
    {
        public float Temperature { get; }
        public float Humidity { get; }

        public WeatherDataChangedEventArgs(float temperature, float humidity)
        {
            Temperature = temperature;
            Humidity = humidity;
        }
    }

    public class Program
    {
        public static void Main()
        {
            WeatherStation weatherStation = new WeatherStation();
            ScreenDisplay screenDisplay = new ScreenDisplay();
            DatabaseSaver databaseSaver = new DatabaseSaver();

            weatherStation.WeatherDataChanged += screenDisplay.ShowWeatherData;
            weatherStation.WeatherDataChanged += databaseSaver.SaveWeatherData;

            // 模拟数据更新
            weatherStation.UpdateWeatherData(25.5f, 70.0f);
        }
    }
}