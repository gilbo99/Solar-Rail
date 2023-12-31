using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EventBus : MonoBehaviour
{
    // Make it static so it can be Access anywhere
    private static EventBus _current;
    public static EventBus Current { get { return _current; } }

    // looks to see if theres not already a event bus if there is it Destroy itself
    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }



    //Makes an Event so it can get called 
    public event Action SolarPanelToggle;
    // is the Event trigger
    public void SolarPanelToggleTrigger()
    {
        SolarPanelToggle();
    }




    public event Action PowerCellsToggle;

    public void PowerCellsToggleTrigger()
    {
        PowerCellsToggle();
    }




    public event Action UiManagerEvent;
    // is the Event trigger
    public void UiManagerEventTrigger()
    {
        UiManagerEvent();
    }


    public event Action GreenHouseMinigame;
    // is the Event trigger
    public void GreenHouseMinigameTrigger()
    {
        GreenHouseMinigame();
    }

    public event Action WaterTankMinigame;
    // is the Event trigger
    public void OptimiseWaterNutrientsTrigger()
    {
        WaterTankMinigame();
    }
}


    /*
     Sub to eventbus
    EventBus.Current.SolarPanelToggle += Immaterialise;


    void Immaterialise()
    {
        // plays audio and turn off and on MeshRenderer and BoxCollider
        audioSource.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = !gameObject.GetComponent<MeshRenderer>().enabled;
        gameObject.GetComponent<BoxCollider>().enabled = !gameObject.GetComponent<BoxCollider>().enabled;
        
        
    }


    when it dies
    EventBus.Current.KillFLoor -= Immaterialise; use with OnDestroy

    */


