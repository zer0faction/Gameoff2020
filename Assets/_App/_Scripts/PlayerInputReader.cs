using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class for reading Controller/Keyboard inputs, NOT for Ui buttons, etc.
public class PlayerInputReader : MonoBehaviour
{
    [SerializeField] private Player player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.Move(new Vector2Int(0,1));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.Move(new Vector2Int(0, -1));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            player.Move(new Vector2Int(-1, 0));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            player.Move(new Vector2Int(1, 0));
        }
    }
}
