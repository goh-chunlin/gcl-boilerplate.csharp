using WTS.Prism.DI.Core.Interfaces;

namespace WTS.Prism.DI.Core.Services
{
    public class CustomService : ICustomService
    {
        public string GetDemoText(int count)
        {
            return $"This is a testing demo text. You've clicked {count} time{(count == 1 ? "" : "s")}.";
        }
    }
}
