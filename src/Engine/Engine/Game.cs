using Engine.Events;
using TinyLog;

namespace Engine
{
    public abstract class Game
    {
        public Form Window => new Window(this);
        internal string Title => GetType().Name;

        public void Run()
        { }

        public virtual void Start()
        {
            Log.Info("Flow engine started...");
            var resizeEvent = new KeyPressedEvent(3,2);
            
            if(resizeEvent.IsInCategory(EventCategory.Input))
                Log.Info(resizeEvent.ToString());
        }
    }
}