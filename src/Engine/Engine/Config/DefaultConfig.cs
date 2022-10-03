using Engine.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Config
{
    internal class DefaultConfig : IConfig
    {
        public Vector2d WindowSize => new Vector2d(320, 180);

        public string Title => "Referendum";
    }
}
