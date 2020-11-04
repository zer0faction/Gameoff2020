using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is responsible for the main gameloop of the game.
// - Moving sends out a message to all other objects in the current board;

public class GameLoop : MonoBehaviour
{
    private static GameLoop _instance;

    public static GameLoop Instance { get { return _instance; } }

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

    public void WarnOtherActors()
    {
        Debug.Log("Warning other actors!");
    }
}
