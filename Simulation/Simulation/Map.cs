namespace Simulation;

public class Map
{
    public Dictionary<(int, int), AbstractEntity?> WorldMap = new();
    private (int, int) _worldSize;
    public (int,int) WorldSize => _worldSize;

    public void GenerateWorld(int width, int length)
    {
        _worldSize = (width, length);
        WorldMap.Clear();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < length; j++)
            {
                WorldMap[(i, j)] = null;
            }
        }
    }

    public void SpawnEntity(int x, int y,EntityType entityType)
    {
        switch (entityType)
        {
            case EntityType.Harbivore:
                WorldMap[(x, y)] = new Harbivore();
                break;
            case EntityType.Predator:
                WorldMap[(x, y)] = new Predator();
                break;
        }
    }
}