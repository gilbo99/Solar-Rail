using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerCellsManager : MonoBehaviour
{
    public GameObject PowerCell;
    public bool PowerCelloff = false;

    public float rotateSpeed = 0.5f;


    
    // Start is called before the first frame update
    void Start()
    {
        
        EventBus.Current.PowerCellsToggle += PowerCells;
    }

    // Update is called once per frame
    



    void PowerCells()
    {
        PowerCelloff = !PowerCelloff;

        PowerCell.GetComponent<PowerCellMover>().enabled = PowerCelloff;

    }


    void OnDestroy()
    {
        EventBus.Current.PowerCellsToggle -= PowerCells;
    }
}
