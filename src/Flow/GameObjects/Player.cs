using System.Windows.Forms;
using Engine;
using SFML.Graphics;
using SFML.System;

namespace Flow.GameObjects;
public class Player : GameObject
{
    private RectangleShape _rectangleShape;
    private int _spriteSize = 64;

    public Player(Vector2f startPosition)
    {
        _rectangleShape = new RectangleShape(new Vector2f(_spriteSize, _spriteSize));
        _rectangleShape.FillColor = Color.Yellow;

        Position = startPosition;
    }
    
    public override void Draw(RenderTarget target, RenderStates states)
    {
        states.Transform *= Transform;
        target.Draw(_rectangleShape, states);
    }

    public void Update(Game game)
    {
        if (game.Input.IsKeyDown(Keys.Left))
            Position += new Vector2f(1, 0);
        
        if (game.Input.IsKeyDown(Keys.Right))
            Position -= new Vector2f(1, 0);
    }
}