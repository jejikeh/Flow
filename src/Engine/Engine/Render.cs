using SFML.Graphics;

namespace Engine;

public class Render
{
    private RenderWindow _render;
    
    private Game _game;

    internal Render(IntPtr handle, Game game)
    {
        _render = new RenderWindow(handle);
        _game = game;
    }

    internal void ClearAndDraw()
    {
        _render.DispatchEvents();
        _render.Clear(_game.VoidColor);
        
        // render game
        _game.Draw();
        
        _render.Display();
    }
}