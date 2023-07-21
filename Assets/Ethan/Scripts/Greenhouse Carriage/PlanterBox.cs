using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanterBox : MonoBehaviour
{
    public GameObject GreenhouseManager;

    // PLANTER ID FOR GREENHOUSE TO CONNECT TO
    
    public int planterboxID;

    public float waterLevel;
    
    private bool beingWatered;

    // VARIABLE FOR TRACKING PLANTER INDIVIDUAL WATER

    // Update is called once per frame
    void Update()
    {
        if(beingWatered)
        {
            waterLevel = 1 * Time.deltaTime;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            beingWatered = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            GreenhouseManager.FetchPlanterStatus(planterboxID, waterLevel);
        }
    }
}
