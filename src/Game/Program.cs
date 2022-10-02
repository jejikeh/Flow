using Engine;
using TinyLog;

namespace Game
{
    internal class App : FlowGame
    {
        public override void Start()
        {
            Log.Info("Flow start    ");
        }
    }
    
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var app = new App();
            EntryPoint.Main(app);            
        }
    }
}