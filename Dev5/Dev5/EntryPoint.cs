using System;

namespace Dev5
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                var workerConsole = new Menu();
                workerConsole.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           
        }
    }
}
