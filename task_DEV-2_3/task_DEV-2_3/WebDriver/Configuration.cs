using static System.Configuration.ConfigurationSettings;

namespace GrowTask.WebDriver
{
    public class Configuration
    {
        public static string _elementTimeout = AppSettings["Timeout"];      
        public static string _selectedBrowser = AppSettings["Browser"];
    }
}