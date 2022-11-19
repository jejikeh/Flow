using System.Drawing.Design;
using Engine.Types;
using SFML.Graphics;
using SFML.System;

namespace Flow.GameObjects;

public class FlowTile : Tile
{
    public override TileType Type { get; set; }

    private RectangleShape _rectangleShape;
        
    public FlowTile(int size, TileType type) : base(size)
    {
        Type = type;
        _rectangleShape = new RectangleShape(new Vector2f(Size, Size));
        switch (Type)
        {
            case TileType.Block:
                _rectangleShape.FillColor = Color.White;
                break;  
            case TileType.None:
                _rectangleShape.FillColor = Color.Black;
                break;
            case TileType.Bonus:
                _rectangleShape.FillColor = Color.Yellow;
                break;
            case TileType.Enemy:
                _rectangleShape.FillColor = Color.Red;
                break;
            case TileType.Player:
                _rectangleShape.FillColor = Color.Green;
                break;
        }

    }

    public override void SetPosition(Vector2f newPosition)
    {
        base.SetPosition(newPosition);
        _rectangleShape.Position = Position;
    }


    public override void Draw(RenderTarget target, RenderStates states)
    {
        base.Draw(target, states);
        target.Draw(_rectangleShape, states);
    }
}