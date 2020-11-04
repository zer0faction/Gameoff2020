using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    [SerializeField] private Item[] items;

    //Singleton -----------
    private static ItemDatabase _instance;
    public static ItemDatabase Instance { get { return _instance; } }

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

    //THIS CLASS IS JUST A LIST OF ITEMS THAT CAN BE FOUND ON THEIR ID'S
    public Item GetItem(int id)
    {
        return items[id];
    }
}
