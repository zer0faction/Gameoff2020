using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is a representation of a single "screen" in the game

public class Map
{
    public int width;
    public int height;
    public EnvironmentTile[,] environmentTiles;
    public ActorTiles[,] actorTiles;
}
