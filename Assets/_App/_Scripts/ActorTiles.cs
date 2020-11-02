using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "NewTile", menuName = "ActorTile")]
public class ActorTiles : ScriptableObject
{
    public Tile tile;
    public Vector2Int currentPos = new Vector2Int(1,1);
}
