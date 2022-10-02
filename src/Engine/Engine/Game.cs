using System.Runtime.InteropServices;
using TinyLog;

namespace Engine
{
    public abstract class Game
    {
        public Form Window { get => new Window(this); }
        internal string Title => GetType().Name;

        public void Run()
        {
            while (true)
                Console.WriteLine("Hello Flow");
        }

        public virtual void Start()
        {
            Log.Info("Flow engine started...");
        }
    }
}