using Engine;
using System.Runtime.InteropServices;
using TinyLog;

namespace Runtime
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            var app = new Flow.Flow();
            Application.Run(app.Window);
        }
    }
}