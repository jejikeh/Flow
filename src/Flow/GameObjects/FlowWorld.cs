using System.Drawing;
using Engine;
using Engine.Types;

namespace Flow.GameObjects;

public class FlowWorld : World<FlowTile>
{
    private Dictionary<char, TileType> _worldPresets = new Dictionary<char, TileType>()
    {
        { '*', TileType.None },
        { 'X', TileType.Block },
        {'S', TileType.Player},
        {'E', TileType.Enemy},
        {'B', TileType.Bonus}
    };
    public FlowWorld(int size, Render render, string level) : base(size, render)
    {
        LoadLevel(level);
    }

    private void LoadLevel(string level)
    {
        var lines = level.Split('\n').Where(x => x != string.Empty).ToArray();
        for (var i = 0; i < lines.Length; i++)
        {
            for (var k = 0; k < lines[i].Length; k++)
            {
                if(!_worldPresets.ContainsKey(lines[i][k])) continue;
                InitTile(new FlowTile(8, _worldPresets[lines[i][k]]),i,k);
            }
        }
    }

    public void ChangeTileType(int x, int y, TileType newType)
    {
        InitTile(new FlowTile(8, newType), x, y);
    }

    public override void InitTile(FlowTile tile, int x, int y)
    {
        base.InitTile(tile, x, y);
        if (tile.Type == TileType.Player)
            
    }
}