using Engine;
using SFML.Graphics;
using SFML.System;

namespace Flow.GameObjects;

public class Bob : GameObject
{
    private RectangleShape _rectangleShape;
    private int _spriteSize = 33;

    public Bob()
    {
        _rectangleShape = new RectangleShape(new Vector2f(_spriteSize, _spriteSize));
        _rectangleShape.Texture = ContentLoader.InitTexture("logo.png");
    }
    
    public override void Draw(RenderTarget target, RenderStates states)
    {
        target.Draw(_rectangleShape);
    }

}