using SFML.Graphics;
using SFML.System;

namespace Engine.Types;

public class World<T> : GameObject where T : Tile
{
    protected T?[][] Tiles;   
    private List<GameObject> _gameObjects = new List<GameObject>();
    private Render _render;
    public int Size { get; private set; }

    public World(int size, Render render)
    {
        Size = size;
        _render = render;
        
        Tiles = new T[Size][];

        for (var i = 0; i < Size; i++)
            Tiles[i] = new T[Size];
    }

    public virtual void InitTile(T tile, int x, int y)
    {
        if (x > Size)
            x = 0;
        if (y > Size)
            y = 0;
        if (x < 0)
            x = Size;
        if (y < 0)
            y = Size;

        Tiles[x][y] = tile;
        Tiles[x][y]!.SetPosition(new Vector2f(y * tile.Size,x * tile.Size));
    }
    
    public void DrawGameObjects(RenderTarget target, RenderStates states)
    {
        // foreach (var gameObject in _gameObjects)
            // _render.Draw(gameObject);
    }

    public override void Draw(RenderTarget target, RenderStates states)
    {
        base.Draw(target, states);

        foreach (var tileRow in Tiles)
        {
            foreach (var tile in tileRow)
            {   
                    if(tile == null) continue;
                    target.Draw(tile);
            }
        }
    }
}