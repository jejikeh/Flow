using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Input
    {
        private List<Keys> _pressedKeys = new List<Keys>();
        
        public Input() { }

        public bool IsKeyDown(Keys keycode) => _pressedKeys.Contains(keycode);

        internal void EventKeyDown(Keys keycode)
        {
            if(!_pressedKeys.Contains(keycode))
                _pressedKeys.Add(keycode);
        }

        internal void EventKeyRelease(Keys keycode) =>
            _pressedKeys.Remove(keycode);
    }
}
