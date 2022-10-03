using Engine.Config;
using Engine.Events;
using Engine.Types;
using SFML.Graphics;
using TinyLog;

namespace Engine
{
    public abstract class Game
    {
        public Form Window => new Window(this);


        internal RenderWindow? SfmlRender;

        public IConfig Config { get; set; }

        public void Run() { }

        internal virtual void Init(IntPtr handle)
        {
            Log.Info("SFML init...");
            SfmlRender = Core.Graphics.InitSFML(handle);

            OnAwake();
        }

        /// <summary>
        /// Exec right before Load()
        /// </summary>
        protected virtual void OnAwake()
        {
            Config = new DefaultConfig();
        }

        public virtual void Load()
        {
            Log.Info("Flow engine started...");
        }

        public virtual void Update()
        {

        }

        /// <summary>
        /// Clear canvas of game window
        /// </summary>
        /// <param name="color"></param>
        public void ClearCanvas(SFML.Graphics.Color color) =>
            Core.Graphics.ClearRender(SfmlRender!, color);
    }
}