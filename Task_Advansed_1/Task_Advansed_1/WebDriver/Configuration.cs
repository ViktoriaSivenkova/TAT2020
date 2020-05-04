using static System.Configuration.ConfigurationSettings;

namespace Task_Advansed_1.WebDriver
{
    public class Configuration
    {
        public static string _elementTimeout = AppSettings["Timeout"];
        public static string _selectedBrowser = AppSettings["Browser"];
    }
}