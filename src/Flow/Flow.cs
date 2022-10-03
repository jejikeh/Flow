using Engine;
using Engine.Types;
using System.Runtime.CompilerServices;
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
            ClearCanvas(SFML.Graphics.Color.Black);
        }
    }
}