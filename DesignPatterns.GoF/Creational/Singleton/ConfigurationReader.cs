namespace DesignPatterns.GoF.Creational.Singleton
{
    public class ConfigurationReader
    {
        private static ConfigurationReader? _instance = default;
        private static readonly object _lock = new();

        private ConfigurationReader() { }

        public static ConfigurationReader Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationReader();
                    }
                }
            }

            return _instance;
        }
    }
}
