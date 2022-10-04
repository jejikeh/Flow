using Engine.Types;
using Engine.Config;

namespace Flow
{
    public class Config : DefaultConfig,Engine.IConfig
    {
        public new Vector2d WindowSize => new Vector2d(1024, 648);

        public new string Title => "Flow";
    }
}
