using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component just keeps a list of allowed tiles.
 * Such a list is used both for pathfinding and for movement.
 */
public class AllowedTiles : MonoBehaviour  {
    [SerializeField] TileBase[] allowedTiles = null;
    public TileBase mountainTile;
    public TileBase shawllowWaterTile;
    public TileBase deeperShallowwWaterTile;

    public TileBase deeperWaterTile;

    public TileBase deepWaterTile;



    public bool Contain(TileBase tile) {
        
        return allowedTiles.Contains(tile);
    }

    public TileBase[] Get() { return allowedTiles;  }

    public void addMountain()
    {
        allowedTiles[4] = mountainTile;
    }
    public void addWater()
    {
        allowedTiles[5] = shawllowWaterTile;
        allowedTiles[6] = deeperShallowwWaterTile;
        allowedTiles[7] = deeperWaterTile;
        allowedTiles[8] = deepWaterTile;

    }
}
