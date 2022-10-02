using SFML;
using SFML.Graphics;

namespace Engine;

internal static class Core
{
    internal static class Graphics
    {
        internal static RenderWindow InitSFML(IntPtr handle) => new(handle);

        internal static void ClearRender(RenderWindow render, SFML.Graphics.Color color)
        {
            render.DispatchEvents();
            render.Clear(color);
            render.Display();
        }
    }

}