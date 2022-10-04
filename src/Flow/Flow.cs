using Engine;
using Engine.Types;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using SFML.Graphics;
using TinyLog;

namespace Flow
{
    public class Flow : Game
    {
        protected override void OnAwake()
        {
            Config = new Config();   
        }

        public override void Load()
        {
        }

        public override void Update()
        {
            base.Update();
            VoidColor = Input.IsKeyDown(Keys.B) ? Color.Green : Color.Magenta;
        }
    }
}