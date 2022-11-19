using SFML.Graphics;
using SFML.System;

namespace Engine.Types;

public abstract class Tile : GameObject
{
    public abstract TileType Type { get; set; }
    public int Size { get; private set; }
    
    public Tile(int size)
    {
        Size = size;
    }

    public virtual void SetPosition(Vector2f newPosition)
    {
        Position = newPosition;
    }
}