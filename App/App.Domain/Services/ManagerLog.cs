using App.Business.Interfaces.Services;
using log4net;

namespace App.Business.Services
{
    public class ManagerLog : IManagerLog
    {
        private ILog _logger;
        public ManagerLog()
        {
            _logger = LogManager.GetLogger("ExampleLog");
            log4net.Config.XmlConfigurator.Configure();
        }

        public void DebugLog(string message) => _logger.Debug(message);
        public void InfoLog(string message) => _logger.Info(message);
        public void WarnLog(string message) => _logger.Warn(message);
        public void ErrorLog(string message) => _logger.Error(message);
        public void FatalLog(string message) => _logger.Fatal(message);
    }
}