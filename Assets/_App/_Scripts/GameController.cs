using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public EnvironmentTile t1, t2, t3, t4;
    public Player player;

    private void Start()
    {
        Debug.Log("Hello world!");

        //Voor nu hardcoden die shit
        Map map = new Map();
        map.actorTiles = new ActorTiles[20, 20];
        map.environmentTiles = new EnvironmentTile[,] {
            { t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t4,t1,t1,t1,t1,t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t4,t1,t1,t1,t4,t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t2,t1,t1,t1,t1,t4,t1,t4,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t2,t2,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t2,t1,t1,t1,t2,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4,t1,t1,t1,t4 },
            { t4,t1,t2,t1,t1,t1,t4,t1,t1,t4,t1,t1,t1,t1,t1,t4,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t4,t1,t1,t4,t1,t1,t2,t1,t1,t4,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t4,t1,t1,t4,t1,t1,t1,t1,t1,t4,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t2,t4,t4,t4,t4,t1,t1,t1,t4,t4,t4,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t2,t1,t1,t1,t1,t1,t4,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t2,t4,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t2,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t2,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t4,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t1,t4 },
            { t4,t1,t1,t1,t4,t1,t1,t1,t1,t1,t1,t1,t1,t2,t2,t1,t1,t1,t1,t4 },
            { t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4,t4 },
        };
        MapController.Instance.SetMap(map);
        MapController.Instance.DrawEnvMap();
        MapController.Instance.SetActorPosition(new Vector2Int(1, 1), player);
    }
}
