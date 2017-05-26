namespace App.Business.Interfaces.Services
{
    public interface IManagerLog
    {
        void DebugLog(string message);
        void InfoLog(string message);
        void WarnLog(string message);
        void ErrorLog(string message);
        void FatalLog(string message);
    }
}
