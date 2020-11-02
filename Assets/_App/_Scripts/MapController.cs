using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapController : MonoBehaviour
{
    //VARIABLES
    [Header("References to other gameobjects/monobehaviour stuff")]
    [SerializeField] private Tilemap tilemapEnv;
    [SerializeField] private Tilemap tilemapActors;

    private Map map;

    //Singleton -----------
    private static MapController _instance;
    public static MapController Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    //Draw the environment tiles.tile on the map.
    public void DrawEnvMap()
    {
        Vector3Int[] positions = new Vector3Int[map.environmentTiles.Length];
        TileBase[] tileArray = new TileBase[map.environmentTiles.Length];

        int index = 0;
        for (int x = 0; x < map.environmentTiles.GetLength(0); x++)
        {
            for (int y = 0; y < map.environmentTiles.GetLength(0); y++)
            {
                positions[index] = new Vector3Int(x, y, 0);
                tileArray[index] = map.environmentTiles[x, y].tile;
                index++;
            }
        }
        tilemapEnv.SetTiles(positions, tileArray);
    }

    public bool AllowedToMove(Vector2Int newVector2Int)
    {
        EnvironmentTile t = map.environmentTiles[newVector2Int.x, newVector2Int.y];
        return t.isTraversable;
    }

    public void UpdateActorPosition(Vector2Int newVector2Int, Vector2Int oldVector2Int, ActorTiles actor)
    {
        map.actorTiles[newVector2Int.x, newVector2Int.y] = actor;
        map.actorTiles[oldVector2Int.x, oldVector2Int.y] = null;

        //Draw on the new tilemap
        tilemapActors.SetTile(new Vector3Int(newVector2Int.x, newVector2Int.y, 0), actor.tile);
        tilemapActors.SetTile(new Vector3Int(oldVector2Int.x, oldVector2Int.y, 0), null);
    }


    public void SetActorPosition(Vector2Int newVector2Int, ActorTiles actor)
    {
        map.actorTiles[newVector2Int.x, newVector2Int.y] = actor;
        tilemapActors.SetTile(new Vector3Int(newVector2Int.x, newVector2Int.y, 0), actor.tile);
    }

    //GETTERS/SETTERS
    public void SetMap(Map map)
    {
        this.map = map;
    }
}
