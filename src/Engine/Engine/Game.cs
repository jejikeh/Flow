using Engine.Events;
using SFML.Graphics;
using TinyLog;

namespace Engine
{
    public abstract class Game
    {
        public Form Window => new Window(this);

        internal Tuple<int, int>? WindowSize { get; set; }
        internal string Title => GetType().Name;

        internal RenderWindow? SfmlRender;

        public void Run() { }

        internal virtual void Init(IntPtr handle)
        {
            Log.Info("SFML init...");
            SfmlRender = Core.Graphics.InitSFML(handle);
            SetWindowSize(1024, 648);


        }

        public virtual void Start()
        {
            Log.Info("Flow engine started...");
        }

        public virtual void Update()
        {

        }

        public void SetWindowSize(int width, int height) =>
            WindowSize = new Tuple<int, int>(width, height);

        public void ClearCanvas(SFML.Graphics.Color color) =>
            Core.Graphics.ClearRender(SfmlRender!, color);
    }
}