namespace Simulation;

public class Simulation
{
    private Map _map = new Map();

    public void CreateNewWorld(int width, int height)
    {
        _map.GenerateWorld(width,height);
    }

    public void SpawnEntity()
    {
        _map.SpawnEntity(0,0,EntityType.Harbivore);
        _map.SpawnEntity(2,2,EntityType.Predator);
    }

    public void RenderMap()
    {
        for (int i = 0; i < _map.WorldSize.Item1; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < _map.WorldSize.Item2; j++)
            {
                var entity = _map.WorldMap[(i, j)];
                if ( entity != null)
                {
                    Console.Out.Write($"\u0020{entity.Icon}\u0020");
                    continue;
                }
                Console.Out.Write("\u0020.\u0020");
            }
        }
    }
}