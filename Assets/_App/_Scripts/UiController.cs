using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    [SerializeField] private GameObject inventoryCanvas;
    private List<GameObject> allCanvases = new List<GameObject>();

    //Bools for what canvas is active
    private bool inventoryCanvasIsActive = false;

    private void Start()
    {
        allCanvases.Add(inventoryCanvas);
    }

    //Singleton -----------
    private static UiController _instance;
    public static UiController Instance { get { return _instance; } }

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

    //All other methods
    public bool OpenCloseInventory()
    {
        inventoryCanvas.SetActive(!inventoryCanvasIsActive);
        inventoryCanvasIsActive = !inventoryCanvasIsActive;
        DisableAllOtherCanveses(inventoryCanvas);
        return !inventoryCanvasIsActive;
    }

    private void DisableAllOtherCanveses(GameObject g1)
    {
        foreach(GameObject g2 in allCanvases)
        {
            if(g2 != g1)
            {
                g2.SetActive(false);
            }
        }
    }
}
