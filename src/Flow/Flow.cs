using Engine;
using Engine.Types;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Flow.GameObjects;
using SFML.Graphics;
using SFML.System;
using TinyLog;

namespace Flow
{
    public class Flow : Game
    {
        private Bob _bob = new Bob();
        private Player _player = new Player(new Vector2f(50,50));
        
        
        protected override void OnAwake()
        {
            Config = new Config();   
            base.OnAwake();
        }

        public override void Load()
        {
        }

        public override void Update()
        {
            base.Update();
            VoidColor = Input.IsKeyDown(Keys.B) ? Color.Green : Color.Magenta;
            
            _player.Update(this);
        }

        public override void Draw()
        {
            Render.Draw(_bob);
            Render.Draw(_player);
        }
    }
}