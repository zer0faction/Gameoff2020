using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "NewTile", menuName = "EnvironmentTile")]
public class EnvironmentTile : ScriptableObject
{
    [SerializeField] int id; //Id to reference in Database
    public Tile tile;

    //Can the player stand on it?
    public bool isTraversable;
}
