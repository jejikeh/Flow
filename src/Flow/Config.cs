using Engine.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flow
{
    public class Config : Engine.IConfig
    {
        public Vector2d WindowSize => new Vector2d(1024, 648);

        public string Title => "Flow";
    }
}
