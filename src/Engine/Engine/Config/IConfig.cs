using Engine.Types;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public interface IConfig
    {
        public Vector2d WindowSize { get;}
        public string Title { get; }
        public int RefreshRate { get; }
        public string PathToContent { get; }

        public bool isDebug { get; }
    }
}
