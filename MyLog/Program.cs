using Serilog;
using Serilog.Core;

namespace MyLog
{
    internal class Program
    {
        private static Logger logger;
        static void Main(string[] args)
        {
            logger = new LoggerConfiguration()
                .WriteTo.File("logs\\" + DateTime.Now.ToString("dd.MM.yyyy") + ".log",
                    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();
            Console.WriteLine("Hello, World!");
            logger.Error("Hello, Exception!");
        }
    }
}
