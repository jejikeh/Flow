using Engine;
using SFML.System;

namespace Flow.GameObjects;

public class CellGrid
{
    private List<List<Vector2f>> _grid = new List<List<Vector2f>>();
    private Dictionary<GameObject, Tuple<int, int>> _storedObjects = new Dictionary<GameObject, Tuple<int, int>>();

    public CellGrid(int x, int y, int gapSize)
    {
        for (var i = 0; i < x; i++)
        {
            _grid.Add(new List<Vector2f>());
            for (var k = 0; k < y; k++)
            {
                _grid[i].Add(new Vector2f(i * gapSize,k * gapSize));
            }
        }
    }

    public void PlaceObjectToGrid(GameObject gameObject, int x, int y)
    {
        gameObject.Position = _grid[x][y];
        _storedObjects.Add(gameObject,new Tuple<int, int>(x,y));
    }

    public void MoveObject(GameObject gameObject, int directionX, int directionY)
    {
        var tempPos = _storedObjects[gameObject];

        if (tempPos.Item1 + directionX >= _grid.Count)
            tempPos = new Tuple<int, int>(0, tempPos.Item2);
        if (tempPos.Item1 + directionX <= 0)
            tempPos = new Tuple<int, int>(_grid.Count, tempPos.Item2);

        if (tempPos.Item2 + directionY >= _grid[0].Count)
            tempPos = new Tuple<int, int>(tempPos.Item1, 0);
        if (tempPos.Item2 + directionY <= 0)
            tempPos = new Tuple<int, int>(tempPos.Item1, _grid[0].Count);

        gameObject.Position = _grid[tempPos.Item1 + directionX][tempPos.Item2 + directionY];
        _storedObjects[gameObject] = new Tuple<int, int>(tempPos.Item1 + directionX, tempPos.Item2 + directionY);
    }
}