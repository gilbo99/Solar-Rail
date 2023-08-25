using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InteractForMinigames : MonoBehaviour
{
    public string MiniGame;
    public GameObject mainCam;
    public GameObject minigameCam;
    public GameObject player;
    public bool cam1stats = true;
    public bool minigamecamstats = false;
    public bool inputbool = false;
    

    [SerializeField] private UIManager uiUpdate;

    //Add GameObject that is gamemanager when setup
    // make sure it triggers OnTriggerExit once minigame is done

   
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.F) & inputbool)
        {

            uiUpdate.UpdateUIText("");
            MiniGameSwitch();

        }

    }
    // Sets text when player enters
    void OnTriggerEnter(Collider other)
    {
       
        inputbool = true;
        if (other.CompareTag("Player"))
        {
             uiUpdate.UpdateUIText("Press F To Start " + MiniGame);
        }


    }
    // Sets text to nothing when player leaves
    void OnTriggerExit(Collider other)
    {
        
        inputbool = false;
        if (other.CompareTag("Player"))
        {
            uiUpdate.UpdateUIText("");
        }

            
    }

    
    // Changes too diffrent camera depending on what you set minigameCam // allways set mainCam too player cam
    void SwitchCam()
    {
        
        cam1stats = !cam1stats;
        minigamecamstats = !minigamecamstats;
        mainCam.SetActive(cam1stats);
        minigameCam.SetActive(minigamecamstats);
        player.SetActive(cam1stats);

    }





    void MiniGameSwitch()
    {

        switch (MiniGame)
        {
            case "Solar Rotate":
                EventBus.Current.SolarPanelToggleTrigger();
                SwitchCam();
                break;

            case "Power Cells Charge":
                EventBus.Current.PowerCellsToggleTrigger();
                SwitchCam();
                break;
            
            case "Water Plants":
                EventBus.Current.GreenHouseMinigameTrigger();
                SwitchCam();
                break;
            case "Optimise Water Nutrients":
                EventBus.Current.OptimiseWaterNutrientsTrigger();
                SwitchCam();
                break;
        }
    }
}
