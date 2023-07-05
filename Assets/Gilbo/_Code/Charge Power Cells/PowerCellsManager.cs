using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PowerCellsManager : MonoBehaviour
{
    public GameObject PowerCell;
    public GameObject sliderUItoggle;
    private bool toggle = false;
    public List<string> objective;
    public List<string> key;
    public GameObject UIManager;
    public Color32 color;


    private UIManager uiUpdate;
   
    void Start()
    {
        
        uiUpdate = UIManager.GetComponent<UIManager>();
        EventBus.Current.PowerCellsToggle += PowerCells;
    }

  
    



    void PowerCells()
    {
        toggle = !toggle;

        PowerCell.GetComponent<PowerCellMover>().enabled = toggle;
        sliderUItoggle.SetActive(toggle);

        if (toggle)
        {
            
            uiUpdate.ObjectiveUpdate(objective[0], objective[1], objective[2], objective[3]);
            uiUpdate.ButtonUpdate(key[0], key[1], key[2]);
            uiUpdate.borderChange(color);

        }
        else
        {
            Color32 color2 = new Color32(225, 255, 0, 0);
            uiUpdate.ObjectiveUpdate("", "", "", "");
            uiUpdate.ButtonUpdate("", "", ""); 
            uiUpdate.borderChange(color2);


        }

    }


    void OnDestroy()
    {
        EventBus.Current.PowerCellsToggle -= PowerCells;
    }
}
