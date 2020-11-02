using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTile", menuName = "Player")]
public class Player : ActorTiles
{
    public void Move(Vector2Int direction)
    {
        Vector2Int v = new Vector2Int(currentPos.x + direction.x, currentPos.y + direction.y);
        if (MapController.Instance.AllowedToMove(v))
        {
            MapController.Instance.UpdateActorPosition(v, currentPos, this);
            currentPos = v;
        } else
        {
            //TODO: message to Console/UI if player cant move here.
        }
    }
}
