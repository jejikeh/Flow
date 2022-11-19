using System.Windows.Forms;
using Engine;
using SFML.Graphics;
using SFML.System;

namespace Flow.GameObjects;
public class Player : GameObject
{
    private RectangleShape _rectangleShape;
    private int _spriteSize = 8;
    private int _updateTickInterval = 4;
    private int _currentTick = 0;

    private Tuple<int, int> _lastInputDirection;


    public Player(Vector2f startPosition)
    {
        _rectangleShape = new RectangleShape(new Vector2f(_spriteSize, _spriteSize));
        _rectangleShape.FillColor = Color.Yellow;

        Position = startPosition;
        _lastInputDirection = new Tuple<int, int>(0, -1);

    }
    
    public override void Draw(RenderTarget target, RenderStates states)
    {
        states.Transform *= Transform;
        target.Draw(_rectangleShape, states);
    }

    public async Task Update(Game game)
    {
        _currentTick++;

        if(_currentTick > _updateTickInterval)
        {
            // Flow.World.MoveObject(this, _lastInputDirection.Item1, _lastInputDirection.Item2);
            _currentTick = 0;
        }

        if (game.Input.IsKeyPressed(Keys.Down) || game.Input.IsKeyPressed(Keys.S))
            _lastInputDirection = new Tuple<int, int>(0, 1);

        if (game.Input.IsKeyPressed(Keys.Left) || game.Input.IsKeyPressed(Keys.A))
            _lastInputDirection = new Tuple<int, int>(-1, 0);

        if (game.Input.IsKeyPressed(Keys.Right) || game.Input.IsKeyPressed(Keys.D))
            _lastInputDirection = new Tuple<int, int>(1, 0);

        if (game.Input.IsKeyPressed(Keys.Up) || game.Input.IsKeyPressed(Keys.W))
            _lastInputDirection = new Tuple<int, int>(0, -1);
    }
}