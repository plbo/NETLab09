using System.Configuration;

namespace Board.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = ConfigurationManager.AppSettings["serviceUri"];
            var factory = new ServiceFactory(uri);
            var service = factory.GetService();
            var cc = new ConsoleController(service);
            cc.Run();
        }
    }
}
