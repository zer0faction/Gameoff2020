using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HealingItem", menuName = "Inventory/HealingItem")]
public class HealingItem : Item
{
    public int healingAmount;

    public override void UseItem()
    {
        
    }
}
