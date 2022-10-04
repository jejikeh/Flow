using Engine.Config;
using Engine.Events;
using Engine.Types;
using SFML.Graphics;
using TinyLog;
using Color = SFML.Graphics.Color;

namespace Engine
{
    public abstract class Game
    {
        public Form Window => new Window(this);

        public IConfig Config { get; set; }
        public Input Input { get; set; }
        public Render Render { get; set; }
        internal ContentLoader ContentLoader { get; set; }


        public Color VoidColor { get; set; }

        internal void Init(IntPtr handle)
        {
            Log.Info("SFML init...");
            Render = new Render(handle, this);
            Input = new Input();
            ContentLoader = new ContentLoader(this);
            
            Config = new DefaultConfig();
            
            OnAwake();
        }
        
        protected virtual void OnAwake()
        {
            if(Config.isDebug)
                ContentLoader.InitContent();
        }

        public virtual void Load()
        {
            Log.Info("Flow engine started...");
        }

        public virtual void Update()
        {
            Render.ClearAndDraw();
        }
        
        public virtual void Draw()
        {
        }
        
        public void OnEvent(Event @event)
        {
            Log.Info(@event.ToString());
            switch (@event.Type)
            {
                case EventType.KeyPressed:
                    KeyEvent keyEvent = @event as KeyEvent;
                    Input.EventKeyDown(keyEvent.KeyCode);
                    break;
                case EventType.KeyReleased:
                    KeyEvent keyEvent1 = @event as KeyEvent;
                    Input.EventKeyRelease(keyEvent1.KeyCode);
                    break;
            }
        }
    }
}