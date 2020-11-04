using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    weapon,
    healing,
}

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public int id;
    public new string name;
    public int weight;

    public ItemType itemType;
    public Sprite itemLogo;

    public virtual void UseItem()
    {
        Debug.Log("UseItem is not implemented.");
    }
}
