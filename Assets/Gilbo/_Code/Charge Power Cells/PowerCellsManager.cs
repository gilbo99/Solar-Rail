using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerCellsManager : MonoBehaviour
{
    public GameObject PowerCell;
    public GameObject sliderUItoggle;
    public bool PowerCelloff = false;
    public List<string> objective;
    public GameObject UIManager;

    public float rotateSpeed = 0.5f;


    private UIManager uiUpdate;
    // Start is called before the first frame update
    void Start()
    {
        uiUpdate = UIManager.GetComponent<UIManager>();
        EventBus.Current.PowerCellsToggle += PowerCells;
    }

    // Update is called once per frame
    



    void PowerCells()
    {
        PowerCelloff = !PowerCelloff;

        PowerCell.GetComponent<PowerCellMover>().enabled = PowerCelloff;
        sliderUItoggle.SetActive(PowerCelloff);

        if (PowerCelloff)
        {
            uiUpdate.ObjectiveUpdate(objective[0], objective[1], objective[2], objective[3]);
        }
        else
        {
            uiUpdate.ObjectiveUpdate("", "", "", "");
        }

    }


    void OnDestroy()
    {
        EventBus.Current.PowerCellsToggle -= PowerCells;
    }
}
